namespace CharacterCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbHumanWH = new System.Windows.Forms.RadioButton();
            this.rbDwarfWH = new System.Windows.Forms.RadioButton();
            this.rbElfWH = new System.Windows.Forms.RadioButton();
            this.rbHalflingWH = new System.Windows.Forms.RadioButton();
            this.rbRandomWH = new System.Windows.Forms.RadioButton();
            this.bGenerateWH = new System.Windows.Forms.Button();
            this.comboBoxWHGenerateAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbHumanSR = new System.Windows.Forms.RadioButton();
            this.rbDwarfSR = new System.Windows.Forms.RadioButton();
            this.rbElfSR = new System.Windows.Forms.RadioButton();
            this.rbTrollSR = new System.Windows.Forms.RadioButton();
            this.rbRandomSR = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSRGenerateAmount = new System.Windows.Forms.ComboBox();
            this.bGenerateSR = new System.Windows.Forms.Button();
            this.rbOrcSR = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warhammer";
            // 
            // rbHumanWH
            // 
            this.rbHumanWH.AutoSize = true;
            this.rbHumanWH.Location = new System.Drawing.Point(15, 42);
            this.rbHumanWH.Name = "rbHumanWH";
            this.rbHumanWH.Size = new System.Drawing.Size(59, 17);
            this.rbHumanWH.TabIndex = 1;
            this.rbHumanWH.TabStop = true;
            this.rbHumanWH.Text = "Human";
            this.rbHumanWH.UseVisualStyleBackColor = true;
            this.rbHumanWH.CheckedChanged += new System.EventHandler(this.rbHumanWH_CheckedChanged);
            // 
            // rbDwarfWH
            // 
            this.rbDwarfWH.AutoSize = true;
            this.rbDwarfWH.Location = new System.Drawing.Point(80, 42);
            this.rbDwarfWH.Name = "rbDwarfWH";
            this.rbDwarfWH.Size = new System.Drawing.Size(53, 17);
            this.rbDwarfWH.TabIndex = 2;
            this.rbDwarfWH.TabStop = true;
            this.rbDwarfWH.Text = "Dwarf";
            this.rbDwarfWH.UseVisualStyleBackColor = true;
            this.rbDwarfWH.CheckedChanged += new System.EventHandler(this.rbDwarfWH_CheckedChanged);
            // 
            // rbElfWH
            // 
            this.rbElfWH.AutoSize = true;
            this.rbElfWH.Location = new System.Drawing.Point(139, 42);
            this.rbElfWH.Name = "rbElfWH";
            this.rbElfWH.Size = new System.Drawing.Size(37, 17);
            this.rbElfWH.TabIndex = 3;
            this.rbElfWH.TabStop = true;
            this.rbElfWH.Text = "Elf";
            this.rbElfWH.UseVisualStyleBackColor = true;
            this.rbElfWH.CheckedChanged += new System.EventHandler(this.rbElfWH_CheckedChanged);
            // 
            // rbHalflingWH
            // 
            this.rbHalflingWH.AutoSize = true;
            this.rbHalflingWH.Location = new System.Drawing.Point(182, 42);
            this.rbHalflingWH.Name = "rbHalflingWH";
            this.rbHalflingWH.Size = new System.Drawing.Size(60, 17);
            this.rbHalflingWH.TabIndex = 4;
            this.rbHalflingWH.TabStop = true;
            this.rbHalflingWH.Text = "Halfling";
            this.rbHalflingWH.UseVisualStyleBackColor = true;
            this.rbHalflingWH.CheckedChanged += new System.EventHandler(this.rbHalflingWH_CheckedChanged);
            // 
            // rbRandomWH
            // 
            this.rbRandomWH.AutoSize = true;
            this.rbRandomWH.Location = new System.Drawing.Point(248, 42);
            this.rbRandomWH.Name = "rbRandomWH";
            this.rbRandomWH.Size = new System.Drawing.Size(65, 17);
            this.rbRandomWH.TabIndex = 5;
            this.rbRandomWH.TabStop = true;
            this.rbRandomWH.Text = "Random";
            this.rbRandomWH.UseVisualStyleBackColor = true;
            this.rbRandomWH.CheckedChanged += new System.EventHandler(this.rbRandomWH_CheckedChanged);
            // 
            // bGenerateWH
            // 
            this.bGenerateWH.Location = new System.Drawing.Point(182, 65);
            this.bGenerateWH.Name = "bGenerateWH";
            this.bGenerateWH.Size = new System.Drawing.Size(111, 23);
            this.bGenerateWH.TabIndex = 6;
            this.bGenerateWH.Text = "Generate";
            this.bGenerateWH.UseVisualStyleBackColor = true;
            this.bGenerateWH.Click += new System.EventHandler(this.bGenerateWH_Click);
            // 
            // comboBoxWHGenerateAmount
            // 
            this.comboBoxWHGenerateAmount.FormattingEnabled = true;
            this.comboBoxWHGenerateAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxWHGenerateAmount.Location = new System.Drawing.Point(118, 67);
            this.comboBoxWHGenerateAmount.Name = "comboBoxWHGenerateAmount";
            this.comboBoxWHGenerateAmount.Size = new System.Drawing.Size(45, 21);
            this.comboBoxWHGenerateAmount.TabIndex = 7;
            this.comboBoxWHGenerateAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxWHGenerateAmount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount to generate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shadowrun";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbHumanSR
            // 
            this.rbHumanSR.AutoSize = true;
            this.rbHumanSR.Location = new System.Drawing.Point(15, 143);
            this.rbHumanSR.Name = "rbHumanSR";
            this.rbHumanSR.Size = new System.Drawing.Size(59, 17);
            this.rbHumanSR.TabIndex = 10;
            this.rbHumanSR.TabStop = true;
            this.rbHumanSR.Text = "Human";
            this.rbHumanSR.UseVisualStyleBackColor = true;
            this.rbHumanSR.CheckedChanged += new System.EventHandler(this.rbHumanSR_CheckedChanged);
            // 
            // rbDwarfSR
            // 
            this.rbDwarfSR.AutoSize = true;
            this.rbDwarfSR.Location = new System.Drawing.Point(80, 143);
            this.rbDwarfSR.Name = "rbDwarfSR";
            this.rbDwarfSR.Size = new System.Drawing.Size(53, 17);
            this.rbDwarfSR.TabIndex = 11;
            this.rbDwarfSR.TabStop = true;
            this.rbDwarfSR.Text = "Dwarf";
            this.rbDwarfSR.UseVisualStyleBackColor = true;
            this.rbDwarfSR.CheckedChanged += new System.EventHandler(this.rbDwarfSR_CheckedChanged);
            // 
            // rbElfSR
            // 
            this.rbElfSR.AutoSize = true;
            this.rbElfSR.Location = new System.Drawing.Point(139, 143);
            this.rbElfSR.Name = "rbElfSR";
            this.rbElfSR.Size = new System.Drawing.Size(37, 17);
            this.rbElfSR.TabIndex = 12;
            this.rbElfSR.TabStop = true;
            this.rbElfSR.Text = "Elf";
            this.rbElfSR.UseVisualStyleBackColor = true;
            this.rbElfSR.CheckedChanged += new System.EventHandler(this.rbElfSR_CheckedChanged);
            // 
            // rbTrollSR
            // 
            this.rbTrollSR.AutoSize = true;
            this.rbTrollSR.Location = new System.Drawing.Point(230, 143);
            this.rbTrollSR.Name = "rbTrollSR";
            this.rbTrollSR.Size = new System.Drawing.Size(45, 17);
            this.rbTrollSR.TabIndex = 13;
            this.rbTrollSR.TabStop = true;
            this.rbTrollSR.Text = "Troll";
            this.rbTrollSR.UseVisualStyleBackColor = true;
            this.rbTrollSR.CheckedChanged += new System.EventHandler(this.rbTrollSR_CheckedChanged);
            // 
            // rbRandomSR
            // 
            this.rbRandomSR.AutoSize = true;
            this.rbRandomSR.Location = new System.Drawing.Point(281, 143);
            this.rbRandomSR.Name = "rbRandomSR";
            this.rbRandomSR.Size = new System.Drawing.Size(65, 17);
            this.rbRandomSR.TabIndex = 14;
            this.rbRandomSR.TabStop = true;
            this.rbRandomSR.Text = "Random";
            this.rbRandomSR.UseVisualStyleBackColor = true;
            this.rbRandomSR.CheckedChanged += new System.EventHandler(this.rbRandomSR_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Amount to generate";
            // 
            // comboBoxSRGenerateAmount
            // 
            this.comboBoxSRGenerateAmount.FormattingEnabled = true;
            this.comboBoxSRGenerateAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSRGenerateAmount.Location = new System.Drawing.Point(118, 171);
            this.comboBoxSRGenerateAmount.Name = "comboBoxSRGenerateAmount";
            this.comboBoxSRGenerateAmount.Size = new System.Drawing.Size(45, 21);
            this.comboBoxSRGenerateAmount.TabIndex = 17;
            this.comboBoxSRGenerateAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxSRGenerateAmount_SelectedIndexChanged);
            // 
            // bGenerateSR
            // 
            this.bGenerateSR.Location = new System.Drawing.Point(182, 171);
            this.bGenerateSR.Name = "bGenerateSR";
            this.bGenerateSR.Size = new System.Drawing.Size(111, 23);
            this.bGenerateSR.TabIndex = 18;
            this.bGenerateSR.Text = "Generate";
            this.bGenerateSR.UseVisualStyleBackColor = true;
            this.bGenerateSR.Click += new System.EventHandler(this.bGenerateSR_Click);
            // 
            // rbOrcSR
            // 
            this.rbOrcSR.AutoSize = true;
            this.rbOrcSR.Location = new System.Drawing.Point(179, 143);
            this.rbOrcSR.Name = "rbOrcSR";
            this.rbOrcSR.Size = new System.Drawing.Size(42, 17);
            this.rbOrcSR.TabIndex = 19;
            this.rbOrcSR.TabStop = true;
            this.rbOrcSR.Text = "Orc";
            this.rbOrcSR.UseVisualStyleBackColor = true;
            this.rbOrcSR.CheckedChanged += new System.EventHandler(this.rbOrcSR_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbOrcSR);
            this.Controls.Add(this.bGenerateSR);
            this.Controls.Add(this.comboBoxSRGenerateAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbRandomSR);
            this.Controls.Add(this.rbTrollSR);
            this.Controls.Add(this.rbElfSR);
            this.Controls.Add(this.rbDwarfSR);
            this.Controls.Add(this.rbHumanSR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWHGenerateAmount);
            this.Controls.Add(this.bGenerateWH);
            this.Controls.Add(this.rbRandomWH);
            this.Controls.Add(this.rbHalflingWH);
            this.Controls.Add(this.rbElfWH);
            this.Controls.Add(this.rbDwarfWH);
            this.Controls.Add(this.rbHumanWH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHumanWH;
        private System.Windows.Forms.RadioButton rbDwarfWH;
        private System.Windows.Forms.RadioButton rbElfWH;
        private System.Windows.Forms.RadioButton rbHalflingWH;
        private System.Windows.Forms.RadioButton rbRandomWH;
        private System.Windows.Forms.Button bGenerateWH;
        private System.Windows.Forms.ComboBox comboBoxWHGenerateAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbHumanSR;
        private System.Windows.Forms.RadioButton rbDwarfSR;
        private System.Windows.Forms.RadioButton rbElfSR;
        private System.Windows.Forms.RadioButton rbTrollSR;
        private System.Windows.Forms.RadioButton rbRandomSR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSRGenerateAmount;
        private System.Windows.Forms.Button bGenerateSR;
        private System.Windows.Forms.RadioButton rbOrcSR;
    }
}

