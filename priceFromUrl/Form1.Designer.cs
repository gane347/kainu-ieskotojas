namespace priceFromUrl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsChk = new System.Windows.Forms.CheckBox();
            this.colFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colTo = new System.Windows.Forms.NumericUpDown();
            this.colUrl = new System.Windows.Forms.NumericUpDown();
            this.colNewPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.compareChk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colOldPrice = new System.Windows.Forms.NumericUpDown();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.findChk = new System.Windows.Forms.CheckBox();
            this.captchaChk = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.saveChk = new System.Windows.Forms.CheckBox();
            this.otherFileLabel = new System.Windows.Forms.Label();
            this.selectOtherFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.colFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNewPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colOldPrice)).BeginInit();
            this.settingsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(24, 20);
            this.selectFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(136, 33);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "pasirinkti failą";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "eilutės nuo:";
            // 
            // settingsChk
            // 
            this.settingsChk.AutoSize = true;
            this.settingsChk.Location = new System.Drawing.Point(8, 144);
            this.settingsChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsChk.Name = "settingsChk";
            this.settingsChk.Size = new System.Drawing.Size(151, 20);
            this.settingsChk.TabIndex = 2;
            this.settingsChk.Text = "detalesni nustatymai";
            this.settingsChk.UseVisualStyleBackColor = true;
            this.settingsChk.CheckedChanged += new System.EventHandler(this.settingsChk_CheckedChanged);
            // 
            // colFrom
            // 
            this.colFrom.Location = new System.Drawing.Point(116, 27);
            this.colFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colFrom.Name = "colFrom";
            this.colFrom.Size = new System.Drawing.Size(75, 22);
            this.colFrom.TabIndex = 3;
            this.colFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "iki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "stulpelis, kuriame yra nuorodos";
            // 
            // colTo
            // 
            this.colTo.Location = new System.Drawing.Point(249, 27);
            this.colTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.colTo.Name = "colTo";
            this.colTo.Size = new System.Drawing.Size(75, 22);
            this.colTo.TabIndex = 8;
            this.colTo.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // colUrl
            // 
            this.colUrl.Location = new System.Drawing.Point(229, 75);
            this.colUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colUrl.Name = "colUrl";
            this.colUrl.Size = new System.Drawing.Size(75, 22);
            this.colUrl.TabIndex = 9;
            this.colUrl.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // colNewPrice
            // 
            this.colNewPrice.Location = new System.Drawing.Point(591, 75);
            this.colNewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colNewPrice.Name = "colNewPrice";
            this.colNewPrice.Size = new System.Drawing.Size(75, 22);
            this.colNewPrice.TabIndex = 10;
            this.colNewPrice.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "stulpelis, į kurį bus įrašomos kainos";
            // 
            // compareChk
            // 
            this.compareChk.AutoSize = true;
            this.compareChk.Location = new System.Drawing.Point(25, 128);
            this.compareChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compareChk.Name = "compareChk";
            this.compareChk.Size = new System.Drawing.Size(106, 20);
            this.compareChk.TabIndex = 12;
            this.compareChk.Text = "lyginti kainas";
            this.compareChk.UseVisualStyleBackColor = true;
            this.compareChk.UseWaitCursor = true;
            this.compareChk.CheckedChanged += new System.EventHandler(this.compareChk_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "stulpelis, kuriame yra senos kainos";
            // 
            // colOldPrice
            // 
            this.colOldPrice.Location = new System.Drawing.Point(249, 162);
            this.colOldPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colOldPrice.Name = "colOldPrice";
            this.colOldPrice.Size = new System.Drawing.Size(75, 22);
            this.colOldPrice.TabIndex = 13;
            this.colOldPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.findChk);
            this.settingsBox.Controls.Add(this.captchaChk);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.label5);
            this.settingsBox.Controls.Add(this.colFrom);
            this.settingsBox.Controls.Add(this.colOldPrice);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.compareChk);
            this.settingsBox.Controls.Add(this.colTo);
            this.settingsBox.Controls.Add(this.colNewPrice);
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.label3);
            this.settingsBox.Controls.Add(this.colUrl);
            this.settingsBox.Location = new System.Drawing.Point(21, 168);
            this.settingsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsBox.Size = new System.Drawing.Size(688, 206);
            this.settingsBox.TabIndex = 15;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "detalesni nustatymai";
            // 
            // findChk
            // 
            this.findChk.AutoSize = true;
            this.findChk.Checked = true;
            this.findChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.findChk.Location = new System.Drawing.Point(351, 160);
            this.findChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findChk.Name = "findChk";
            this.findChk.Size = new System.Drawing.Size(103, 20);
            this.findChk.TabIndex = 16;
            this.findChk.Text = "ieškoti kainų";
            this.findChk.UseVisualStyleBackColor = true;
            this.findChk.UseWaitCursor = true;
            // 
            // captchaChk
            // 
            this.captchaChk.AutoSize = true;
            this.captchaChk.Location = new System.Drawing.Point(351, 128);
            this.captchaChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.captchaChk.Name = "captchaChk";
            this.captchaChk.Size = new System.Drawing.Size(189, 20);
            this.captchaChk.TabIndex = 15;
            this.captchaChk.Text = "didesnė puslapių apsauga";
            this.captchaChk.UseVisualStyleBackColor = true;
            this.captchaChk.UseWaitCursor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(137, 394);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(152, 34);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "ieškoti kainų...";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(22, 64);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(122, 16);
            this.fileLabel.TabIndex = 17;
            this.fileLabel.Text = "nepasirinktas failas";
            // 
            // saveChk
            // 
            this.saveChk.AutoSize = true;
            this.saveChk.Location = new System.Drawing.Point(295, 27);
            this.saveChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveChk.Name = "saveChk";
            this.saveChk.Size = new System.Drawing.Size(184, 20);
            this.saveChk.TabIndex = 18;
            this.saveChk.Text = "rezultatą saugoti į kitą failą";
            this.saveChk.UseVisualStyleBackColor = true;
            this.saveChk.CheckedChanged += new System.EventHandler(this.saveChk_CheckedChanged);
            // 
            // otherFileLabel
            // 
            this.otherFileLabel.AutoSize = true;
            this.otherFileLabel.Enabled = false;
            this.otherFileLabel.Location = new System.Drawing.Point(22, 93);
            this.otherFileLabel.Name = "otherFileLabel";
            this.otherFileLabel.Size = new System.Drawing.Size(122, 16);
            this.otherFileLabel.TabIndex = 19;
            this.otherFileLabel.Text = "nepasirinktas failas";
            // 
            // selectOtherFileBtn
            // 
            this.selectOtherFileBtn.Enabled = false;
            this.selectOtherFileBtn.Location = new System.Drawing.Point(495, 20);
            this.selectOtherFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectOtherFileBtn.Name = "selectOtherFileBtn";
            this.selectOtherFileBtn.Size = new System.Drawing.Size(139, 33);
            this.selectOtherFileBtn.TabIndex = 20;
            this.selectOtherFileBtn.Text = "pasirinkti failą";
            this.selectOtherFileBtn.UseVisualStyleBackColor = true;
            this.selectOtherFileBtn.Click += new System.EventHandler(this.selectOtherFileBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(331, 396);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 28);
            this.progressBar1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(751, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(463, 426);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.selectFileBtn);
            this.groupBox1.Controls.Add(this.fileLabel);
            this.groupBox1.Controls.Add(this.selectOtherFileBtn);
            this.groupBox1.Controls.Add(this.saveChk);
            this.groupBox1.Controls.Add(this.otherFileLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 123);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pagrindiniai nustatymai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.settingsChk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kainų tikrintojas";
            ((System.ComponentModel.ISupportInitialize)(this.colFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNewPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colOldPrice)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox settingsChk;
        private System.Windows.Forms.NumericUpDown colFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown colTo;
        private System.Windows.Forms.NumericUpDown colUrl;
        private System.Windows.Forms.NumericUpDown colNewPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox compareChk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown colOldPrice;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.CheckBox saveChk;
        private System.Windows.Forms.Label otherFileLabel;
        private System.Windows.Forms.Button selectOtherFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox captchaChk;
        private System.Windows.Forms.CheckBox findChk;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

