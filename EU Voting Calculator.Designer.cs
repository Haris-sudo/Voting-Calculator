namespace WinForms_VotingCalculator
{
    partial class EUVotingCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPopPercentLbl = new System.Windows.Forms.Label();
            this.totalPopLbl = new System.Windows.Forms.Label();
            this.horizontalLine2 = new System.Windows.Forms.Label();
            this.abstainRadioBtn = new System.Windows.Forms.RadioButton();
            this.noRadioBtn = new System.Windows.Forms.RadioButton();
            this.yesRadioBtn = new System.Windows.Forms.RadioButton();
            this.votingSettingsLbl = new System.Windows.Forms.Label();
            this.resetEnabledBtn = new System.Windows.Forms.Button();
            this.eurozoneOnlyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countryEnabledCB = new System.Windows.Forms.CheckBox();
            this.countryFlagImg = new System.Windows.Forms.PictureBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.verticalLine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finalResultLbl = new System.Windows.Forms.Label();
            this.finalResultVarLbl = new System.Windows.Forms.Label();
            this.votingResultImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingResultImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalPopPercentLbl);
            this.panel1.Controls.Add(this.totalPopLbl);
            this.panel1.Controls.Add(this.horizontalLine2);
            this.panel1.Controls.Add(this.abstainRadioBtn);
            this.panel1.Controls.Add(this.noRadioBtn);
            this.panel1.Controls.Add(this.yesRadioBtn);
            this.panel1.Controls.Add(this.votingSettingsLbl);
            this.panel1.Controls.Add(this.resetEnabledBtn);
            this.panel1.Controls.Add(this.eurozoneOnlyBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countryEnabledCB);
            this.panel1.Controls.Add(this.countryFlagImg);
            this.panel1.Controls.Add(this.countryBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 397);
            this.panel1.TabIndex = 0;
            // 
            // totalPopPercentLbl
            // 
            this.totalPopPercentLbl.AutoSize = true;
            this.totalPopPercentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopPercentLbl.Location = new System.Drawing.Point(31, 344);
            this.totalPopPercentLbl.Name = "totalPopPercentLbl";
            this.totalPopPercentLbl.Size = new System.Drawing.Size(189, 16);
            this.totalPopPercentLbl.TabIndex = 11;
            this.totalPopPercentLbl.Text = "Population percentage: xx.xx%";
            // 
            // totalPopLbl
            // 
            this.totalPopLbl.AutoSize = true;
            this.totalPopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopLbl.Location = new System.Drawing.Point(58, 312);
            this.totalPopLbl.Name = "totalPopLbl";
            this.totalPopLbl.Size = new System.Drawing.Size(129, 16);
            this.totalPopLbl.TabIndex = 10;
            this.totalPopLbl.Text = "Total population: xxx";
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine2.Location = new System.Drawing.Point(-1, 289);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(250, 2);
            this.horizontalLine2.TabIndex = 9;
            // 
            // abstainRadioBtn
            // 
            this.abstainRadioBtn.AutoSize = true;
            this.abstainRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.abstainRadioBtn.Location = new System.Drawing.Point(166, 258);
            this.abstainRadioBtn.Name = "abstainRadioBtn";
            this.abstainRadioBtn.Size = new System.Drawing.Size(71, 20);
            this.abstainRadioBtn.TabIndex = 8;
            this.abstainRadioBtn.TabStop = true;
            this.abstainRadioBtn.Text = "Abstain";
            this.abstainRadioBtn.UseVisualStyleBackColor = true;
            // 
            // noRadioBtn
            // 
            this.noRadioBtn.AutoSize = true;
            this.noRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.noRadioBtn.Location = new System.Drawing.Point(99, 258);
            this.noRadioBtn.Name = "noRadioBtn";
            this.noRadioBtn.Size = new System.Drawing.Size(44, 20);
            this.noRadioBtn.TabIndex = 7;
            this.noRadioBtn.TabStop = true;
            this.noRadioBtn.Text = "No";
            this.noRadioBtn.UseVisualStyleBackColor = true;
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.yesRadioBtn.Location = new System.Drawing.Point(17, 257);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(50, 20);
            this.yesRadioBtn.TabIndex = 6;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes";
            this.yesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // votingSettingsLbl
            // 
            this.votingSettingsLbl.AutoSize = true;
            this.votingSettingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.votingSettingsLbl.Location = new System.Drawing.Point(66, 234);
            this.votingSettingsLbl.Name = "votingSettingsLbl";
            this.votingSettingsLbl.Size = new System.Drawing.Size(112, 16);
            this.votingSettingsLbl.TabIndex = 5;
            this.votingSettingsLbl.Text = "Voting Settings";
            // 
            // resetEnabledBtn
            // 
            this.resetEnabledBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.resetEnabledBtn.Location = new System.Drawing.Point(123, 171);
            this.resetEnabledBtn.Name = "resetEnabledBtn";
            this.resetEnabledBtn.Size = new System.Drawing.Size(119, 47);
            this.resetEnabledBtn.TabIndex = 4;
            this.resetEnabledBtn.Text = "Reset disabled countries";
            this.resetEnabledBtn.UseVisualStyleBackColor = true;
            // 
            // eurozoneOnlyBtn
            // 
            this.eurozoneOnlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.eurozoneOnlyBtn.Location = new System.Drawing.Point(4, 171);
            this.eurozoneOnlyBtn.Name = "eurozoneOnlyBtn";
            this.eurozoneOnlyBtn.Size = new System.Drawing.Size(119, 47);
            this.eurozoneOnlyBtn.TabIndex = 1;
            this.eurozoneOnlyBtn.Text = "Eurozone countries only";
            this.eurozoneOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 2);
            this.label1.TabIndex = 3;
            // 
            // countryEnabledCB
            // 
            this.countryEnabledCB.AutoSize = true;
            this.countryEnabledCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.countryEnabledCB.Location = new System.Drawing.Point(55, 151);
            this.countryEnabledCB.Name = "countryEnabledCB";
            this.countryEnabledCB.Size = new System.Drawing.Size(132, 20);
            this.countryEnabledCB.TabIndex = 2;
            this.countryEnabledCB.Text = "Country enabled?";
            this.countryEnabledCB.UseVisualStyleBackColor = true;
            this.countryEnabledCB.Click += new System.EventHandler(this.countryEnabledCB_Click);
            // 
            // countryFlagImg
            // 
            this.countryFlagImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.countryFlagImg.Location = new System.Drawing.Point(4, 32);
            this.countryFlagImg.Name = "countryFlagImg";
            this.countryFlagImg.Size = new System.Drawing.Size(238, 113);
            this.countryFlagImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryFlagImg.TabIndex = 1;
            this.countryFlagImg.TabStop = false;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.countryBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(4, 5);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(238, 23);
            this.countryBox.TabIndex = 0;
            this.countryBox.Text = "Choose a country...";
            this.countryBox.SelectedIndexChanged += new System.EventHandler(this.countryBox_SelectedIndexChanged);
            this.countryBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxFormat);
            // 
            // verticalLine
            // 
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.Location = new System.Drawing.Point(254, 0);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(2, 382);
            this.verticalLine.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(550, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 382);
            this.label3.TabIndex = 13;
            // 
            // finalResultLbl
            // 
            this.finalResultLbl.AutoSize = true;
            this.finalResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.finalResultLbl.Location = new System.Drawing.Point(609, 273);
            this.finalResultLbl.Name = "finalResultLbl";
            this.finalResultLbl.Size = new System.Drawing.Size(130, 26);
            this.finalResultLbl.TabIndex = 12;
            this.finalResultLbl.Text = "Final result";
            // 
            // finalResultVarLbl
            // 
            this.finalResultVarLbl.AutoSize = true;
            this.finalResultVarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.finalResultVarLbl.Location = new System.Drawing.Point(623, 304);
            this.finalResultVarLbl.Name = "finalResultVarLbl";
            this.finalResultVarLbl.Size = new System.Drawing.Size(105, 26);
            this.finalResultVarLbl.TabIndex = 14;
            this.finalResultVarLbl.Text = "Approved";
            // 
            // votingResultImg
            // 
            this.votingResultImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.votingResultImg.Location = new System.Drawing.Point(561, 44);
            this.votingResultImg.Name = "votingResultImg";
            this.votingResultImg.Size = new System.Drawing.Size(225, 213);
            this.votingResultImg.TabIndex = 12;
            this.votingResultImg.TabStop = false;
            // 
            // EUVotingCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 382);
            this.Controls.Add(this.votingResultImg);
            this.Controls.Add(this.finalResultVarLbl);
            this.Controls.Add(this.finalResultLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.panel1);
            this.Name = "EUVotingCalculator";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingResultImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox countryEnabledCB;
        private System.Windows.Forms.PictureBox countryFlagImg;
        private System.Windows.Forms.Button eurozoneOnlyBtn;
        private System.Windows.Forms.Button resetEnabledBtn;
        private System.Windows.Forms.Label totalPopPercentLbl;
        private System.Windows.Forms.Label totalPopLbl;
        private System.Windows.Forms.Label horizontalLine2;
        private System.Windows.Forms.RadioButton abstainRadioBtn;
        private System.Windows.Forms.RadioButton noRadioBtn;
        private System.Windows.Forms.RadioButton yesRadioBtn;
        private System.Windows.Forms.Label votingSettingsLbl;
        private System.Windows.Forms.Label verticalLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label finalResultLbl;
        private System.Windows.Forms.Label finalResultVarLbl;
        private System.Windows.Forms.PictureBox votingResultImg;
    }
}

