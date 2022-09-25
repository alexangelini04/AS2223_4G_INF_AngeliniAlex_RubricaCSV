namespace AS2223_4G_INF_AngeliniAlex_RubricaCSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.cmbCognome = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(96, 38);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(407, 23);
            this.txtFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(132, 116);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(324, 23);
            this.txtCognome.TabIndex = 3;
            // 
            // cmbCognome
            // 
            this.cmbCognome.FormattingEnabled = true;
            this.cmbCognome.Location = new System.Drawing.Point(482, 116);
            this.cmbCognome.Name = "cmbCognome";
            this.cmbCognome.Size = new System.Drawing.Size(95, 23);
            this.cmbCognome.TabIndex = 4;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(267, 174);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(87, 31);
            this.btnVisualizza.TabIndex = 5;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 15;
            this.lstElenco.Location = new System.Drawing.Point(52, 238);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(525, 169);
            this.lstElenco.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFile;
        private Label label1;
        private Label label2;
        private TextBox txtCognome;
        private ComboBox cmbCognome;
        private Button btnVisualizza;
        private ListBox lstElenco;
        private Button button1;
    }
}