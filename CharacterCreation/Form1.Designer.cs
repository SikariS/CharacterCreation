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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warhammer";
            // 
            // rbHumanWH
            // 
            this.rbHumanWH.AutoSize = true;
            this.rbHumanWH.Location = new System.Drawing.Point(15, 26);
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
            this.rbDwarfWH.Location = new System.Drawing.Point(80, 26);
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
            this.rbElfWH.Location = new System.Drawing.Point(139, 26);
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
            this.rbHalflingWH.Location = new System.Drawing.Point(182, 26);
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
            this.rbRandomWH.Location = new System.Drawing.Point(248, 26);
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
            this.bGenerateWH.Location = new System.Drawing.Point(121, 49);
            this.bGenerateWH.Name = "bGenerateWH";
            this.bGenerateWH.Size = new System.Drawing.Size(75, 23);
            this.bGenerateWH.TabIndex = 6;
            this.bGenerateWH.Text = "Generate";
            this.bGenerateWH.UseVisualStyleBackColor = true;
            this.bGenerateWH.Click += new System.EventHandler(this.bGenerateWH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGenerateWH);
            this.Controls.Add(this.rbRandomWH);
            this.Controls.Add(this.rbHalflingWH);
            this.Controls.Add(this.rbElfWH);
            this.Controls.Add(this.rbDwarfWH);
            this.Controls.Add(this.rbHumanWH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

