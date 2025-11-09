namespace DLWMS.WinApp
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            pictureBox1 = new PictureBox();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 13F);
            lblKonekcijaInfo.Location = new Point(181, 107);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 30);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Font = new Font("Segoe UI", 12F);
            btnIzvjestaj.Location = new Point(243, 179);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(154, 43);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Prikaži izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(293, 28);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(239, 112);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Button 1";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 279);
            Controls.Add(btnDodaj);
            Controls.Add(pictureBox1);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Početna";
            Load += frmPocetna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private PictureBox pictureBox1;
        private Button btnDodaj;
    }
}