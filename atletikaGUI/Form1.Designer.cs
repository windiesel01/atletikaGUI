namespace atletikaGUI
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
            this.listBox_nemzetek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_versenyszam = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_aranyos_nemzetek = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_kereses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_neve = new System.Windows.Forms.Label();
            this.label_eredmeny = new System.Windows.Forms.Label();
            this.label_nemzet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // listBox_nemzetek
            // 
            this.listBox_nemzetek.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_nemzetek.FormattingEnabled = true;
            this.listBox_nemzetek.ItemHeight = 18;
            this.listBox_nemzetek.Location = new System.Drawing.Point(36, 56);
            this.listBox_nemzetek.Name = "listBox_nemzetek";
            this.listBox_nemzetek.Size = new System.Drawing.Size(237, 508);
            this.listBox_nemzetek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(329, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // listBox_versenyszam
            // 
            this.listBox_versenyszam.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listBox_versenyszam.FormattingEnabled = true;
            this.listBox_versenyszam.ItemHeight = 16;
            this.listBox_versenyszam.Location = new System.Drawing.Point(333, 56);
            this.listBox_versenyszam.Name = "listBox_versenyszam";
            this.listBox_versenyszam.Size = new System.Drawing.Size(212, 68);
            this.listBox_versenyszam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(329, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Válassza ki az érmes helyezést:";
            // 
            // button_aranyos_nemzetek
            // 
            this.button_aranyos_nemzetek.BackColor = System.Drawing.Color.SkyBlue;
            this.button_aranyos_nemzetek.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_aranyos_nemzetek.FlatAppearance.BorderSize = 3;
            this.button_aranyos_nemzetek.Font = new System.Drawing.Font("Verdana", 12F);
            this.button_aranyos_nemzetek.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_aranyos_nemzetek.Location = new System.Drawing.Point(62, 570);
            this.button_aranyos_nemzetek.Name = "button_aranyos_nemzetek";
            this.button_aranyos_nemzetek.Size = new System.Drawing.Size(191, 41);
            this.button_aranyos_nemzetek.TabIndex = 5;
            this.button_aranyos_nemzetek.Text = "aranyos - nemzetek";
            this.button_aranyos_nemzetek.UseVisualStyleBackColor = false;
            this.button_aranyos_nemzetek.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(333, 174);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 27);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_kereses
            // 
            this.button_kereses.BackColor = System.Drawing.Color.SkyBlue;
            this.button_kereses.Font = new System.Drawing.Font("Verdana", 12F);
            this.button_kereses.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_kereses.Location = new System.Drawing.Point(363, 282);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(147, 46);
            this.button_kereses.TabIndex = 7;
            this.button_kereses.Text = "keresés";
            this.button_kereses.UseVisualStyleBackColor = false;
            this.button_kereses.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(328, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Versenyző adatai:";
            // 
            // label_neve
            // 
            this.label_neve.AutoSize = true;
            this.label_neve.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_neve.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_neve.Location = new System.Drawing.Point(373, 459);
            this.label_neve.Name = "label_neve";
            this.label_neve.Size = new System.Drawing.Size(54, 18);
            this.label_neve.TabIndex = 9;
            this.label_neve.Text = "neve:";
            // 
            // label_eredmeny
            // 
            this.label_eredmeny.AutoSize = true;
            this.label_eredmeny.Font = new System.Drawing.Font("Verdana", 12F);
            this.label_eredmeny.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_eredmeny.Location = new System.Drawing.Point(328, 491);
            this.label_eredmeny.Name = "label_eredmeny";
            this.label_eredmeny.Size = new System.Drawing.Size(105, 18);
            this.label_eredmeny.TabIndex = 10;
            this.label_eredmeny.Text = "eredménye:";
            // 
            // label_nemzet
            // 
            this.label_nemzet.AutoSize = true;
            this.label_nemzet.Font = new System.Drawing.Font("Verdana", 12F);
            this.label_nemzet.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_nemzet.Location = new System.Drawing.Point(345, 522);
            this.label_nemzet.Name = "label_nemzet";
            this.label_nemzet.Size = new System.Drawing.Size(86, 18);
            this.label_nemzet.TabIndex = 11;
            this.label_nemzet.Text = "nemzete:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(761, 661);
            this.Controls.Add(this.label_nemzet);
            this.Controls.Add(this.label_eredmeny);
            this.Controls.Add(this.label_neve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_aranyos_nemzetek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_versenyszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_nemzetek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Férfiak eredménye a 2017-es atlétikai VB-n";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_nemzetek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_versenyszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_aranyos_nemzetek;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_neve;
        private System.Windows.Forms.Label label_eredmeny;
        private System.Windows.Forms.Label label_nemzet;
    }
}

