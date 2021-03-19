
namespace WindowsFormsApp_Football_Team
{
    partial class Form2
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
            this.StadiumPctBx = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CountryPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StadiumPctBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // StadiumPctBx
            // 
            this.StadiumPctBx.BackgroundImage = global::WindowsFormsApp_Football_Team.Properties.Resources.stadium;
            this.StadiumPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StadiumPctBx.Location = new System.Drawing.Point(0, 104);
            this.StadiumPctBx.Name = "StadiumPctBx";
            this.StadiumPctBx.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.StadiumPctBx.ShadowDecoration.Parent = this.StadiumPctBx;
            this.StadiumPctBx.Size = new System.Drawing.Size(400, 539);
            this.StadiumPctBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StadiumPctBx.TabIndex = 0;
            this.StadiumPctBx.TabStop = false;
            // 
            // CountryPctBx
            // 
            this.CountryPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CountryPctBx.Location = new System.Drawing.Point(0, 1);
            this.CountryPctBx.Name = "CountryPctBx";
            this.CountryPctBx.ShadowDecoration.Parent = this.CountryPctBx;
            this.CountryPctBx.Size = new System.Drawing.Size(217, 80);
            this.CountryPctBx.TabIndex = 1;
            this.CountryPctBx.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 638);
            this.Controls.Add(this.CountryPctBx);
            this.Controls.Add(this.StadiumPctBx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soccer";
            ((System.ComponentModel.ISupportInitialize)(this.StadiumPctBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryPctBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox StadiumPctBx;
        private Guna.UI2.WinForms.Guna2PictureBox CountryPctBx;
    }
}