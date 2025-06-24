using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace priceFromUrl
{
    public partial class Form1 : Form
    {
        private Process pythonProcess;
        private void SetSettingsVisibility()
        {
            colOldPrice.Enabled = compareChk.Checked;
            settingsBox.Enabled = settingsChk.Checked;
        }
        private void SetOtherFileVisibility()
        {
            selectOtherFileBtn.Enabled = saveChk.Checked;
            otherFileLabel.Enabled = saveChk.Checked;
        }
        /// <summary>
        /// Settings are loaded from a file named "settings.txt" in the Debug directory.
        /// </summary>
        private void LoadSettings()
        {
            string settingsFilePath = "settings.txt";

            if (!File.Exists(settingsFilePath))
            {
                MessageBox.Show("Settings file (settings.txt) not found. Using default values.", "Settings Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(settingsFilePath);

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();
                    if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith("#"))
                    {
                        continue; // Skip empty lines or comments
                    }

                    int equalsIndex = trimmedLine.IndexOf('=');
                    if (equalsIndex > 0)
                    {
                        string key = trimmedLine.Substring(0, equalsIndex).Trim();
                        string value = trimmedLine.Substring(equalsIndex + 1).Trim();

                        // Remove quotes if present for string values
                        if (value.StartsWith("\"") && value.EndsWith("\""))
                        {
                            value = value.Substring(1, value.Length - 2);
                        }

                        switch (key)
                        {
                            case "input_file":
                                openFileDialog1.FileName = value;
                                ChangeFileLabels();
                                break;
                            case "output_file":
                                saveFileDialog1.FileName = value;
                                ChangeFileLabels();
                                break;
                            case "column_from":
                                if (int.TryParse(value, out int colFromValue))
                                    colFrom.Value = colFromValue;
                                break;
                            case "column_to":
                                if (int.TryParse(value, out int colToValue))
                                    colTo.Value = colToValue;
                                break;
                            case "column_url":
                                if (int.TryParse(value, out int colUrlValue))
                                    colUrl.Value = colUrlValue;
                                break;
                            case "column_old_price":
                                if (int.TryParse(value, out int colOldPriceValue))
                                    colOldPrice.Value = colOldPriceValue;
                                break;
                            case "column_new_price":
                                if (int.TryParse(value, out int colNewPriceValue))
                                    colNewPrice.Value = colNewPriceValue;
                                break;
                            case "captcha":
                                if (bool.TryParse(value, out bool cap))
                                    captchaChk.Checked = cap;
                                break;
                            case "search":
                                if (bool.TryParse(value, out bool srch))
                                    findChk.Checked = srch;
                                break;
                            case "compare":
                                if (bool.TryParse(value, out bool comp))
                                    compareChk.Checked = comp;
                                break;
                            case "write_to_other_file":
                                if (bool.TryParse(value, out bool writeOther))
                                    saveChk.Checked = writeOther;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Settings Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Settings are saved to a file named "settings.txt" in the Debug directory.
        /// </summary>
        private void SaveSettings()
        {
            string settingsFilePath = Path.Combine(Application.StartupPath, "settings.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(settingsFilePath))
                {
                    writer.WriteLine($"input_file=\"{openFileDialog1.FileName}\"");
                    writer.WriteLine($"output_file=\"{saveFileDialog1.FileName}\"");
                    writer.WriteLine($"column_from={colFrom.Value}");
                    writer.WriteLine($"column_to={colTo.Value}");
                    writer.WriteLine($"column_url={colUrl.Value}");
                    writer.WriteLine($"column_old_price={colOldPrice.Value}");
                    writer.WriteLine($"column_new_price={colNewPrice.Value}");
                    writer.WriteLine($"captcha={captchaChk.Checked}");
                    writer.WriteLine($"search={findChk.Checked}");
                    writer.WriteLine($"compare={compareChk.Checked}");
                    writer.WriteLine($"write_to_other_file={saveChk.Checked}");
                }
                // MessageBox.Show("Settings saved successfully!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Save Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Change the labels for the writing file and reading file.
        /// </summary>
        private void ChangeFileLabels()
        {
            if (openFileDialog1.FileName != "")
            {
                fileLabel.Text = "Skaitymo failas: " + openFileDialog1.FileName;
            }
            else
            {
                fileLabel.Text = "nepasirinktas failas";
            }
            if (saveFileDialog1.FileName != "")
            {
                otherFileLabel.Text = "Rašymo failas: " + saveFileDialog1.FileName;
            }
            else
            {
                otherFileLabel.Text = "nepasirinktas failas";
            }
        }
        /// <summary>
        /// This calls the script that searches the web for prices with the provided arguments.
        /// </summary>
        /// <param name="path"> path to script </param>
        private void RunSearch(string path)
        {
            progressBar1.Value = 0;
            searchBtn.Enabled = false;

            // Start process
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "dist/main/main.exe";
            psi.Arguments = path;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            pythonProcess = new Process();
            pythonProcess.StartInfo = psi;

            pythonProcess.OutputDataReceived += PythonProcess_OutputDataReceived;
            pythonProcess.EnableRaisingEvents = true;

            pythonProcess.Exited += (s, ev) =>
            {
                // This will be called when the process exits
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.Value = 100;
                        searchBtn.Enabled = true;
                        progressBar1.Visible = false;
                        MessageBox.Show("Darbas baigtas!");
                    }));
                }
                else
                {
                    progressBar1.Value = 100;
                    searchBtn.Enabled = true;
                    MessageBox.Show("Darbas baigtas!");
                }
            };

            pythonProcess.Start();
            pythonProcess.BeginOutputReadLine();
        }
        /// <summary>
        /// This method handles the output from the process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PythonProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                const string progressPrefix = "Progress: ";
                if (e.Data.StartsWith(progressPrefix))
                {
                    string numbersPart = e.Data.Substring(progressPrefix.Length);
                    string[] parts = numbersPart.Split('/');

                    if (parts.Length == 2 && int.TryParse(parts[0], out int current) && int.TryParse(parts[1], out int total))
                    {
                        if (total > 0)
                        {
                            int percentage = (int)((double)current / total * 100);
                            if (this.InvokeRequired)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    progressBar1.Value = Math.Min(progressBar1.Maximum, Math.Max(progressBar1.Minimum, percentage));
                                }));
                            }
                            else
                            {
                                progressBar1.Value = Math.Min(progressBar1.Maximum, Math.Max(progressBar1.Minimum, percentage));
                            }
                        }
                    }
                }
                else if (e.Data == "FINISHED")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() => progressBar1.Value = 100));
                    }
                    else
                    {
                        progressBar1.Value = 100;
                    }
                }

                // RichTextBox is offscreen, if you extend the window it will be visible
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => richTextBox1.AppendText(e.Data + Environment.NewLine)));
                }
                else
                {
                    richTextBox1.AppendText(e.Data + Environment.NewLine);
                }
            }
        }
    }
}
