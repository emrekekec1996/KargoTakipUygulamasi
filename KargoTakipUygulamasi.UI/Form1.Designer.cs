namespace KargoTakipUygulamasi.UI
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
            label1 = new Label();
            txtKargo = new TextBox();
            btnNoAta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(50, 52);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 0;
            label1.Text = "Kargo Numarası:";
            // 
            // txtKargo
            // 
            txtKargo.BackColor = Color.WhiteSmoke;
            txtKargo.Font = new Font("Segoe UI", 12F);
            txtKargo.ForeColor = Color.Black;
            txtKargo.Location = new Point(178, 42);
            txtKargo.Name = "txtKargo";
            txtKargo.Size = new Size(150, 29);
            txtKargo.TabIndex = 1;
            txtKargo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNoAta
            // 
            btnNoAta.BackColor = Color.MediumSeaGreen;
            btnNoAta.FlatStyle = FlatStyle.Flat;
            btnNoAta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNoAta.ForeColor = Color.White;
            btnNoAta.Location = new Point(50, 106);
            btnNoAta.Name = "btnNoAta";
            btnNoAta.Size = new Size(320, 53);
            btnNoAta.TabIndex = 2;
            btnNoAta.Text = "Kargo Numarası Ata";
            btnNoAta.UseVisualStyleBackColor = false;
            btnNoAta.Click += btnNoAta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(450, 212);
            Controls.Add(btnNoAta);
            Controls.Add(txtKargo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kargo Takip Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private TextBox txtKargo;
        private Button btnNoAta;
    }
}
