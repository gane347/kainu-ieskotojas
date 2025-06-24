using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace priceFromUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            SetSettingsVisibility();
            SetOtherFileVisibility();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private void compareChk_CheckedChanged(object sender, EventArgs e)
        {
            if(compareChk.Checked)
            {
                colOldPrice.Enabled = true;
            }
            else
            {
                colOldPrice.Enabled = false;
            }
        }

        private void settingsChk_CheckedChanged(object sender, EventArgs e)
        {
            SetSettingsVisibility();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ChangeFileLabels();
        }

        private void selectOtherFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ChangeFileLabels();
        }

        private void saveChk_CheckedChanged(object sender, EventArgs e)
        {
            SetOtherFileVisibility();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            progressBar1.Visible = true;
            string destination = saveFileDialog1.FileName;
            if (destination == "" || !saveChk.Checked)
                destination = openFileDialog1.FileName;
            Task.Run(() => RunSearch(
                $"--source \"{openFileDialog1.FileName}\" " +
                $"--destination \"{destination}\" " +
                $"--from_index {colFrom.Value} " +
                $"--to_index {colTo.Value} " +
                $"--captchas {captchaChk.Checked} " +
                $"--new_price {colNewPrice.Value} " +
                $"--old_price {colOldPrice.Value} " +
                $"--url {colUrl.Value} " +
                $"--compare {compareChk.Checked} " +
                $"--find {findChk.Checked}"));
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Kill the process if form is closing
            if (pythonProcess != null && !pythonProcess.HasExited)
            {
                try
                {
                    if (!pythonProcess.CloseMainWindow())
                    {
                        pythonProcess.Kill();
                        Debug.WriteLine("Python process killed because the form is closing.");
                    }
                    else
                    {
                        pythonProcess.WaitForExit(5000);
                        if (!pythonProcess.HasExited)
                        {
                            pythonProcess.Kill();
                            Debug.WriteLine("Python process forcefully killed after graceful close failed.");
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Debug.WriteLine($"Error terminating Python process (likely already exited): {ex.Message}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An unexpected error occurred trying to terminate Python process: {ex.Message}");
                }
            }

            base.OnFormClosing(e);
        }
    }
}
