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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUVotingCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.votingRule = new System.Windows.Forms.ComboBox();
            this.totalPopVar = new System.Windows.Forms.Label();
            this.totalPopPercentVar = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.popCalcPanel = new System.Windows.Forms.Panel();
            this.popMinYes = new System.Windows.Forms.Label();
            this.horizontalLine3 = new System.Windows.Forms.Label();
            this.popAbstainLbl = new System.Windows.Forms.Label();
            this.popNoLbl = new System.Windows.Forms.Label();
            this.popYesLbl = new System.Windows.Forms.Label();
            this.popPercentAbstain = new System.Windows.Forms.Label();
            this.popPercentNo = new System.Windows.Forms.Label();
            this.popPercentYes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verticalLine3 = new System.Windows.Forms.Label();
            this.popDesc = new System.Windows.Forms.Label();
            this.popTitle = new System.Windows.Forms.Label();
            this.PercentSign = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msMinYes = new System.Windows.Forms.Label();
            this.msAbstainLbl = new System.Windows.Forms.Label();
            this.msNoLbl = new System.Windows.Forms.Label();
            this.msYesLbl = new System.Windows.Forms.Label();
            this.msPercentAbstain = new System.Windows.Forms.Label();
            this.msPercentNo = new System.Windows.Forms.Label();
            this.msPercentYes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.msDesc = new System.Windows.Forms.Label();
            this.msTitle = new System.Windows.Forms.Label();
            this.totalEnabledStates = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingResultImg)).BeginInit();
            this.popCalcPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.votingRule);
            this.panel1.Controls.Add(this.totalPopVar);
            this.panel1.Controls.Add(this.totalPopPercentVar);
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
            this.panel1.Size = new System.Drawing.Size(248, 407);
            this.panel1.TabIndex = 0;
            // 
            // votingRule
            // 
            this.votingRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.votingRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.votingRule.FormattingEnabled = true;
            this.votingRule.Items.AddRange(new object[] {
            "Qualified majority",
            "Reinforced qualified majority",
            "Simple majority",
            "Unanimity"});
            this.votingRule.Location = new System.Drawing.Point(4, 380);
            this.votingRule.Name = "votingRule";
            this.votingRule.Size = new System.Drawing.Size(238, 23);
            this.votingRule.TabIndex = 14;
            this.votingRule.SelectedIndexChanged += new System.EventHandler(this.votingRule_SelectedIndexChanged);
            // 
            // totalPopVar
            // 
            this.totalPopVar.AutoSize = true;
            this.totalPopVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopVar.Location = new System.Drawing.Point(161, 335);
            this.totalPopVar.Name = "totalPopVar";
            this.totalPopVar.Size = new System.Drawing.Size(14, 16);
            this.totalPopVar.TabIndex = 13;
            this.totalPopVar.Text = "x";
            // 
            // totalPopPercentVar
            // 
            this.totalPopPercentVar.AutoSize = true;
            this.totalPopPercentVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopPercentVar.Location = new System.Drawing.Point(161, 355);
            this.totalPopPercentVar.Name = "totalPopPercentVar";
            this.totalPopPercentVar.Size = new System.Drawing.Size(14, 16);
            this.totalPopPercentVar.TabIndex = 12;
            this.totalPopPercentVar.Text = "x";
            // 
            // totalPopPercentLbl
            // 
            this.totalPopPercentLbl.AutoSize = true;
            this.totalPopPercentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopPercentLbl.Location = new System.Drawing.Point(19, 355);
            this.totalPopPercentLbl.Name = "totalPopPercentLbl";
            this.totalPopPercentLbl.Size = new System.Drawing.Size(147, 16);
            this.totalPopPercentLbl.TabIndex = 11;
            this.totalPopPercentLbl.Text = "Population percentage:";
            // 
            // totalPopLbl
            // 
            this.totalPopLbl.AutoSize = true;
            this.totalPopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.totalPopLbl.Location = new System.Drawing.Point(58, 335);
            this.totalPopLbl.Name = "totalPopLbl";
            this.totalPopLbl.Size = new System.Drawing.Size(108, 16);
            this.totalPopLbl.TabIndex = 10;
            this.totalPopLbl.Text = "Total population:";
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine2.Location = new System.Drawing.Point(-1, 322);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(250, 2);
            this.horizontalLine2.TabIndex = 9;
            // 
            // abstainRadioBtn
            // 
            this.abstainRadioBtn.AutoSize = true;
            this.abstainRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.abstainRadioBtn.Location = new System.Drawing.Point(166, 287);
            this.abstainRadioBtn.Name = "abstainRadioBtn";
            this.abstainRadioBtn.Size = new System.Drawing.Size(71, 20);
            this.abstainRadioBtn.TabIndex = 8;
            this.abstainRadioBtn.TabStop = true;
            this.abstainRadioBtn.Text = "Abstain";
            this.abstainRadioBtn.UseVisualStyleBackColor = true;
            this.abstainRadioBtn.Click += new System.EventHandler(this.abstainRadioBtn_Click);
            // 
            // noRadioBtn
            // 
            this.noRadioBtn.AutoSize = true;
            this.noRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.noRadioBtn.Location = new System.Drawing.Point(99, 287);
            this.noRadioBtn.Name = "noRadioBtn";
            this.noRadioBtn.Size = new System.Drawing.Size(44, 20);
            this.noRadioBtn.TabIndex = 7;
            this.noRadioBtn.TabStop = true;
            this.noRadioBtn.Text = "No";
            this.noRadioBtn.UseVisualStyleBackColor = true;
            this.noRadioBtn.CheckedChanged += new System.EventHandler(this.noRadioBtn_CheckedChanged);
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.yesRadioBtn.Location = new System.Drawing.Point(17, 286);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(50, 20);
            this.yesRadioBtn.TabIndex = 6;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes";
            this.yesRadioBtn.UseVisualStyleBackColor = true;
            this.yesRadioBtn.CheckedChanged += new System.EventHandler(this.yesRadioBtn_CheckedChanged);
            // 
            // votingSettingsLbl
            // 
            this.votingSettingsLbl.AutoSize = true;
            this.votingSettingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.votingSettingsLbl.Location = new System.Drawing.Point(66, 263);
            this.votingSettingsLbl.Name = "votingSettingsLbl";
            this.votingSettingsLbl.Size = new System.Drawing.Size(112, 16);
            this.votingSettingsLbl.TabIndex = 5;
            this.votingSettingsLbl.Text = "Voting Settings";
            // 
            // resetEnabledBtn
            // 
            this.resetEnabledBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.resetEnabledBtn.Location = new System.Drawing.Point(123, 200);
            this.resetEnabledBtn.Name = "resetEnabledBtn";
            this.resetEnabledBtn.Size = new System.Drawing.Size(119, 47);
            this.resetEnabledBtn.TabIndex = 4;
            this.resetEnabledBtn.Text = "Reset disabled countries";
            this.resetEnabledBtn.UseVisualStyleBackColor = true;
            this.resetEnabledBtn.Click += new System.EventHandler(this.resetEnabledBtn_Click);
            // 
            // eurozoneOnlyBtn
            // 
            this.eurozoneOnlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.eurozoneOnlyBtn.Location = new System.Drawing.Point(4, 200);
            this.eurozoneOnlyBtn.Name = "eurozoneOnlyBtn";
            this.eurozoneOnlyBtn.Size = new System.Drawing.Size(119, 47);
            this.eurozoneOnlyBtn.TabIndex = 1;
            this.eurozoneOnlyBtn.Text = "Eurozone countries only";
            this.eurozoneOnlyBtn.UseVisualStyleBackColor = true;
            this.eurozoneOnlyBtn.Click += new System.EventHandler(this.eurozoneOnlyBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 2);
            this.label1.TabIndex = 3;
            // 
            // countryEnabledCB
            // 
            this.countryEnabledCB.AutoSize = true;
            this.countryEnabledCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.countryEnabledCB.Location = new System.Drawing.Point(55, 180);
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
            this.countryFlagImg.Size = new System.Drawing.Size(238, 142);
            this.countryFlagImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryFlagImg.TabIndex = 1;
            this.countryFlagImg.TabStop = false;
            // 
            // countryBox
            // 
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.countryBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(4, 5);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(238, 23);
            this.countryBox.TabIndex = 0;
            this.countryBox.SelectedIndexChanged += new System.EventHandler(this.countryBox_SelectedIndexChanged);
            this.countryBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxFormat);
            // 
            // verticalLine
            // 
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.Location = new System.Drawing.Point(248, 0);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(2, 382);
            this.verticalLine.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(651, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 409);
            this.label3.TabIndex = 13;
            // 
            // finalResultLbl
            // 
            this.finalResultLbl.AutoSize = true;
            this.finalResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.finalResultLbl.Location = new System.Drawing.Point(710, 305);
            this.finalResultLbl.Name = "finalResultLbl";
            this.finalResultLbl.Size = new System.Drawing.Size(139, 26);
            this.finalResultLbl.TabIndex = 12;
            this.finalResultLbl.Text = "Final Result";
            // 
            // finalResultVarLbl
            // 
            this.finalResultVarLbl.AutoSize = true;
            this.finalResultVarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.finalResultVarLbl.Location = new System.Drawing.Point(724, 336);
            this.finalResultVarLbl.Name = "finalResultVarLbl";
            this.finalResultVarLbl.Size = new System.Drawing.Size(105, 26);
            this.finalResultVarLbl.TabIndex = 14;
            this.finalResultVarLbl.Text = "Approved";
            // 
            // votingResultImg
            // 
            this.votingResultImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.votingResultImg.Image = ((System.Drawing.Image)(resources.GetObject("votingResultImg.Image")));
            this.votingResultImg.Location = new System.Drawing.Point(662, 64);
            this.votingResultImg.Name = "votingResultImg";
            this.votingResultImg.Size = new System.Drawing.Size(222, 218);
            this.votingResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.votingResultImg.TabIndex = 12;
            this.votingResultImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(255, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 2);
            this.label2.TabIndex = 15;
            // 
            // popCalcPanel
            // 
            this.popCalcPanel.Controls.Add(this.popMinYes);
            this.popCalcPanel.Controls.Add(this.horizontalLine3);
            this.popCalcPanel.Controls.Add(this.popAbstainLbl);
            this.popCalcPanel.Controls.Add(this.popNoLbl);
            this.popCalcPanel.Controls.Add(this.popYesLbl);
            this.popCalcPanel.Controls.Add(this.popPercentAbstain);
            this.popCalcPanel.Controls.Add(this.popPercentNo);
            this.popCalcPanel.Controls.Add(this.popPercentYes);
            this.popCalcPanel.Controls.Add(this.label4);
            this.popCalcPanel.Controls.Add(this.verticalLine3);
            this.popCalcPanel.Controls.Add(this.popDesc);
            this.popCalcPanel.Controls.Add(this.popTitle);
            this.popCalcPanel.Controls.Add(this.PercentSign);
            this.popCalcPanel.Location = new System.Drawing.Point(248, 208);
            this.popCalcPanel.Name = "popCalcPanel";
            this.popCalcPanel.Size = new System.Drawing.Size(402, 195);
            this.popCalcPanel.TabIndex = 16;
            // 
            // popMinYes
            // 
            this.popMinYes.AutoSize = true;
            this.popMinYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popMinYes.Location = new System.Drawing.Point(324, 54);
            this.popMinYes.Name = "popMinYes";
            this.popMinYes.Size = new System.Drawing.Size(15, 16);
            this.popMinYes.TabIndex = 3;
            this.popMinYes.Text = "x";
            // 
            // horizontalLine3
            // 
            this.horizontalLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine3.Location = new System.Drawing.Point(0, 1);
            this.horizontalLine3.Name = "horizontalLine3";
            this.horizontalLine3.Size = new System.Drawing.Size(406, 2);
            this.horizontalLine3.TabIndex = 18;
            // 
            // popAbstainLbl
            // 
            this.popAbstainLbl.AutoSize = true;
            this.popAbstainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popAbstainLbl.Location = new System.Drawing.Point(307, 150);
            this.popAbstainLbl.Name = "popAbstainLbl";
            this.popAbstainLbl.Size = new System.Drawing.Size(55, 17);
            this.popAbstainLbl.TabIndex = 10;
            this.popAbstainLbl.Text = "Abstain";
            // 
            // popNoLbl
            // 
            this.popNoLbl.AutoSize = true;
            this.popNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popNoLbl.Location = new System.Drawing.Point(190, 150);
            this.popNoLbl.Name = "popNoLbl";
            this.popNoLbl.Size = new System.Drawing.Size(26, 17);
            this.popNoLbl.TabIndex = 9;
            this.popNoLbl.Text = "No";
            // 
            // popYesLbl
            // 
            this.popYesLbl.AutoSize = true;
            this.popYesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popYesLbl.Location = new System.Drawing.Point(55, 150);
            this.popYesLbl.Name = "popYesLbl";
            this.popYesLbl.Size = new System.Drawing.Size(32, 17);
            this.popYesLbl.TabIndex = 8;
            this.popYesLbl.Text = "Yes";
            // 
            // popPercentAbstain
            // 
            this.popPercentAbstain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popPercentAbstain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.popPercentAbstain.Location = new System.Drawing.Point(273, 106);
            this.popPercentAbstain.Name = "popPercentAbstain";
            this.popPercentAbstain.Size = new System.Drawing.Size(129, 49);
            this.popPercentAbstain.TabIndex = 7;
            this.popPercentAbstain.Text = "100.00";
            this.popPercentAbstain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popPercentNo
            // 
            this.popPercentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popPercentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.popPercentNo.Location = new System.Drawing.Point(138, 106);
            this.popPercentNo.Name = "popPercentNo";
            this.popPercentNo.Size = new System.Drawing.Size(129, 49);
            this.popPercentNo.TabIndex = 6;
            this.popPercentNo.Text = "100.00";
            this.popPercentNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popPercentYes
            // 
            this.popPercentYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popPercentYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(28)))));
            this.popPercentYes.Location = new System.Drawing.Point(3, 106);
            this.popPercentYes.Name = "popPercentYes";
            this.popPercentYes.Size = new System.Drawing.Size(129, 49);
            this.popPercentYes.TabIndex = 5;
            this.popPercentYes.Text = "100.00";
            this.popPercentYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(270, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 120);
            this.label4.TabIndex = 4;
            // 
            // verticalLine3
            // 
            this.verticalLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine3.Location = new System.Drawing.Point(135, 82);
            this.verticalLine3.Name = "verticalLine3";
            this.verticalLine3.Size = new System.Drawing.Size(2, 120);
            this.verticalLine3.TabIndex = 3;
            // 
            // popDesc
            // 
            this.popDesc.AutoSize = true;
            this.popDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popDesc.Location = new System.Drawing.Point(85, 54);
            this.popDesc.Name = "popDesc";
            this.popDesc.Size = new System.Drawing.Size(242, 17);
            this.popDesc.TabIndex = 2;
            this.popDesc.Text = "Minimum “Yes” required for adoption:";
            // 
            // popTitle
            // 
            this.popTitle.AutoSize = true;
            this.popTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popTitle.Location = new System.Drawing.Point(84, 26);
            this.popTitle.Name = "popTitle";
            this.popTitle.Size = new System.Drawing.Size(94, 20);
            this.popTitle.TabIndex = 1;
            this.popTitle.Text = "Population";
            // 
            // PercentSign
            // 
            this.PercentSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PercentSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentSign.Location = new System.Drawing.Point(9, 12);
            this.PercentSign.Name = "PercentSign";
            this.PercentSign.Size = new System.Drawing.Size(66, 61);
            this.PercentSign.TabIndex = 0;
            this.PercentSign.Text = "%";
            this.PercentSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.msMinYes);
            this.panel2.Controls.Add(this.msAbstainLbl);
            this.panel2.Controls.Add(this.msNoLbl);
            this.panel2.Controls.Add(this.msYesLbl);
            this.panel2.Controls.Add(this.msPercentAbstain);
            this.panel2.Controls.Add(this.msPercentNo);
            this.panel2.Controls.Add(this.msPercentYes);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.msDesc);
            this.panel2.Controls.Add(this.msTitle);
            this.panel2.Controls.Add(this.totalEnabledStates);
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 202);
            this.panel2.TabIndex = 17;
            // 
            // msMinYes
            // 
            this.msMinYes.AutoSize = true;
            this.msMinYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMinYes.Location = new System.Drawing.Point(324, 53);
            this.msMinYes.Name = "msMinYes";
            this.msMinYes.Size = new System.Drawing.Size(15, 16);
            this.msMinYes.TabIndex = 18;
            this.msMinYes.Text = "x";
            // 
            // msAbstainLbl
            // 
            this.msAbstainLbl.AutoSize = true;
            this.msAbstainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msAbstainLbl.Location = new System.Drawing.Point(307, 150);
            this.msAbstainLbl.Name = "msAbstainLbl";
            this.msAbstainLbl.Size = new System.Drawing.Size(55, 17);
            this.msAbstainLbl.TabIndex = 10;
            this.msAbstainLbl.Text = "Abstain";
            // 
            // msNoLbl
            // 
            this.msNoLbl.AutoSize = true;
            this.msNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msNoLbl.Location = new System.Drawing.Point(190, 150);
            this.msNoLbl.Name = "msNoLbl";
            this.msNoLbl.Size = new System.Drawing.Size(26, 17);
            this.msNoLbl.TabIndex = 9;
            this.msNoLbl.Text = "No";
            // 
            // msYesLbl
            // 
            this.msYesLbl.AutoSize = true;
            this.msYesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msYesLbl.Location = new System.Drawing.Point(55, 150);
            this.msYesLbl.Name = "msYesLbl";
            this.msYesLbl.Size = new System.Drawing.Size(32, 17);
            this.msYesLbl.TabIndex = 8;
            this.msYesLbl.Text = "Yes";
            // 
            // msPercentAbstain
            // 
            this.msPercentAbstain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPercentAbstain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msPercentAbstain.Location = new System.Drawing.Point(273, 106);
            this.msPercentAbstain.Name = "msPercentAbstain";
            this.msPercentAbstain.Size = new System.Drawing.Size(129, 49);
            this.msPercentAbstain.TabIndex = 7;
            this.msPercentAbstain.Text = "100.00";
            this.msPercentAbstain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msPercentNo
            // 
            this.msPercentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPercentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.msPercentNo.Location = new System.Drawing.Point(138, 106);
            this.msPercentNo.Name = "msPercentNo";
            this.msPercentNo.Size = new System.Drawing.Size(129, 49);
            this.msPercentNo.TabIndex = 6;
            this.msPercentNo.Text = "100.00";
            this.msPercentNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msPercentYes
            // 
            this.msPercentYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPercentYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(28)))));
            this.msPercentYes.Location = new System.Drawing.Point(3, 106);
            this.msPercentYes.Name = "msPercentYes";
            this.msPercentYes.Size = new System.Drawing.Size(129, 49);
            this.msPercentYes.TabIndex = 5;
            this.msPercentYes.Text = "100.00";
            this.msPercentYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(270, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2, 120);
            this.label11.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(135, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 120);
            this.label12.TabIndex = 3;
            // 
            // msDesc
            // 
            this.msDesc.AutoSize = true;
            this.msDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msDesc.Location = new System.Drawing.Point(85, 52);
            this.msDesc.Name = "msDesc";
            this.msDesc.Size = new System.Drawing.Size(242, 17);
            this.msDesc.TabIndex = 2;
            this.msDesc.Text = "Minimum “Yes” required for adoption:";
            // 
            // msTitle
            // 
            this.msTitle.AutoSize = true;
            this.msTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTitle.Location = new System.Drawing.Point(84, 24);
            this.msTitle.Name = "msTitle";
            this.msTitle.Size = new System.Drawing.Size(131, 20);
            this.msTitle.TabIndex = 1;
            this.msTitle.Text = "Member States";
            // 
            // totalEnabledStates
            // 
            this.totalEnabledStates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalEnabledStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.totalEnabledStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnabledStates.Location = new System.Drawing.Point(9, 12);
            this.totalEnabledStates.Name = "totalEnabledStates";
            this.totalEnabledStates.Size = new System.Drawing.Size(69, 68);
            this.totalEnabledStates.TabIndex = 0;
            this.totalEnabledStates.Text = "27";
            this.totalEnabledStates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EUVotingCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.votingResultImg);
            this.Controls.Add(this.finalResultVarLbl);
            this.Controls.Add(this.finalResultLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popCalcPanel);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EUVotingCalculator";
            this.Text = "EU Voting Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingResultImg)).EndInit();
            this.popCalcPanel.ResumeLayout(false);
            this.popCalcPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label totalPopPercentVar;
        private System.Windows.Forms.Label totalPopVar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel popCalcPanel;
        private System.Windows.Forms.Label popDesc;
        private System.Windows.Forms.Label popTitle;
        private System.Windows.Forms.Label PercentSign;
        private System.Windows.Forms.ComboBox votingRule;
        private System.Windows.Forms.Label popMinYes;
        private System.Windows.Forms.Label popAbstainLbl;
        private System.Windows.Forms.Label popNoLbl;
        private System.Windows.Forms.Label popYesLbl;
        private System.Windows.Forms.Label popPercentAbstain;
        private System.Windows.Forms.Label popPercentNo;
        private System.Windows.Forms.Label popPercentYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label verticalLine3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label msMinYes;
        private System.Windows.Forms.Label msAbstainLbl;
        private System.Windows.Forms.Label msNoLbl;
        private System.Windows.Forms.Label msYesLbl;
        private System.Windows.Forms.Label msPercentAbstain;
        private System.Windows.Forms.Label msPercentNo;
        private System.Windows.Forms.Label msPercentYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label msDesc;
        private System.Windows.Forms.Label msTitle;
        private System.Windows.Forms.Label totalEnabledStates;
        private System.Windows.Forms.Label horizontalLine3;
    }
}

