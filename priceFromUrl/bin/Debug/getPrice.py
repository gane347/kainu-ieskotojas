from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as ec
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
import undetected_chromedriver as uc
import time
import random
import re
import pandas as pd
import sys


def get_prices(urls, solve_captcha):
    prices = {}
    driver = setup_colab_driver()
    progress = 1

    try:
        for url in urls:
            print(f"Scraping page: {url}\n")
            sys.stdout.write(f"Progress: {progress}/{len(urls)+1}\n")
            sys.stdout.flush()
            progress += 1
            # Assign a default value for bad URLs
            if pd.isna(url) or url is None or (isinstance(url, str) and url.strip() == ""):
                print(f"--> Bad URL detected: '{url}'. Setting price to '0'.")
                prices[url] = '0'
                continue

            driver.get(url)
            human_like_delay(1, 2)  # Wait for page to load

            # Handle Cloudflare and CAPTCHA challenges
            page_source = driver.page_source.lower()
            page_title = driver.title.lower()

            if "just a moment" in page_title or "checking your browser" in page_source:
                print("Cloudflare challenge detected. Trying to bypass...")
                # Quit current headless driver
                driver.quit()
                # Start new driver with GUI (non-headless)
                driver = setup_driver(headless=False)
                driver.get(url)
                print("Browser window opened, please solve the CAPTCHA manually.")
                if solve_captcha:
                    input("Press Enter after solving CAPTCHA to continue...")

            # Get price from source code
            try:
                selector = "[data-qa='product_page_price']"  # Selector for pigu.lt
                if "varle" in url:
                    selector = ".price-value"  # Selector for varle.lt
                new_price_element = WebDriverWait(driver, 2).until(
                    ec.presence_of_element_located((By.CSS_SELECTOR, selector))
                )

                # Extract the text content
                price_text = new_price_element.text
                if "pigu" in url:
                    prices[url] = get_pigu_price_refined(price_text)
                else:
                    prices[url] = price_text

            except Exception as e:
                print(f"Error finding or processing price: {e}")
                return None
    finally:
        try:
            driver.quit()
            return prices
        except Exception as e:
            print(f"Error closing file: {e}")
            pass


def get_pigu_price_refined(price_text):
    # Prices in pigu.lt are formatted in a weird way. I use regex to format them correctly
    match = re.search(r'(\d+)\s*(\d+)\s*(€|EUR)?', price_text)

    if match:
        whole_part = match.group(1)
        decimal_part = match.group(2)
        # Combine the parts with a dot for float conversion
        new_price_str = f"{whole_part}.{decimal_part}"
        try:
            new_price = float(new_price_str)
            print(f"Got price: '{new_price_str}'")
            return new_price
        except ValueError:
            print(f"Could not convert '{new_price_str}' to float.")
            return None
    else:
        print("Could not parse the new price from the text.")
        return None


def human_like_delay(min_seconds=1, max_seconds=3):
    time.sleep(random.uniform(min_seconds, max_seconds))


def setup_colab_driver():
    try:
        # Regular Selenium with WebDriver Manager
        options = Options()
        options.add_argument('--headless')
        options.add_argument('--no-sandbox')
        options.add_argument('--disable-dev-shm-usage')
        options.add_argument('--disable-gpu')
        options.add_argument('--window-size=1920,1080')
        options.add_argument(
            '--user-agent='
            'Mozilla/5.0 (Windows NT 10.0; Win64; x64) '
            'AppleWebKit/537.36 (KHTML, like Gecko) '
            'Chrome/120.0.0.0 Safari/537.36')

        service = Service(ChromeDriverManager().install())
        driver = webdriver.Chrome(service=service, options=options)
        print("Using regular Selenium with WebDriver Manager")
        return driver

    except Exception as e:
        print(f"WebDriver Manager failed: {e}")

        try:
            # System Chrome
            options = Options()
            options.add_argument('--headless')
            options.add_argument('--no-sandbox')
            options.add_argument('--disable-dev-shm-usage')
            options.add_argument('--disable-gpu')
            options.add_argument('--window-size=1920,1080')
            options.binary_location = '/usr/bin/chromium-browser'

            driver = webdriver.Chrome(options=options)
            print("Using system Chrome")
            return driver

        except Exception as e:
            print(f"System Chrome failed: {e}")
            raise Exception("All Chrome driver methods failed. Please check installation.")


def setup_driver(headless=True):
    options = uc.ChromeOptions()
    if headless:
        options.add_argument('--headless')
    options.add_argument('--no-sandbox')
    options.add_argument('--disable-dev-shm-usage')
    options.add_argument('--window-size=1920,1080')
    options.add_argument('--user-agent=Mozilla/5.0 '
                         '(Windows NT 10.0; Win64; x64) '
                         'AppleWebKit/537.36 (KHTML, like Gecko) '
                         'Chrome/120.0.0.0 Safari/537.36')
    driver = uc.Chrome(options=options)
    return driver
