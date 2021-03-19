
namespace WindowsFormsApp_Football_Team
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NumberLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPctBx
            // 
            this.PlayerPctBx.BorderRadius = 5;
            this.PlayerPctBx.Image = global::WindowsFormsApp_Football_Team.Properties.Resources.Player;
            this.PlayerPctBx.Location = new System.Drawing.Point(0, 0);
            this.PlayerPctBx.Name = "PlayerPctBx";
            this.PlayerPctBx.ShadowDecoration.Parent = this.PlayerPctBx;
            this.PlayerPctBx.Size = new System.Drawing.Size(41, 56);
            this.PlayerPctBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPctBx.TabIndex = 0;
            this.PlayerPctBx.TabStop = false;
            // 
            // NumberLbl
            // 
            this.NumberLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(65)))), ((int)(((byte)(128)))));
            this.NumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(252)))), ((int)(((byte)(0)))));
            this.NumberLbl.Location = new System.Drawing.Point(10, 12);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(15, 15);
            this.NumberLbl.TabIndex = 1;
            this.NumberLbl.Text = "99";
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.ForeColor = System.Drawing.Color.Black;
            this.NameLbl.Location = new System.Drawing.Point(0, 55);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(39, 20);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.PlayerPctBx);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(74, 75);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPctBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PlayerPctBx;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameLbl;
    }
}
