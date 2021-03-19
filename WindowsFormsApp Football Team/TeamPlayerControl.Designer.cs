
namespace WindowsFormsApp_Football_Team
{
    partial class TeamPlayerControl
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
            this.PlayerPositionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlayerNameTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.PlayerNumberTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // PlayerPositionBtn
            // 
            this.PlayerPositionBtn.BorderRadius = 5;
            this.PlayerPositionBtn.CheckedState.Parent = this.PlayerPositionBtn;
            this.PlayerPositionBtn.CustomImages.Parent = this.PlayerPositionBtn;
            this.PlayerPositionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlayerPositionBtn.ForeColor = System.Drawing.Color.White;
            this.PlayerPositionBtn.HoverState.Parent = this.PlayerPositionBtn;
            this.PlayerPositionBtn.Location = new System.Drawing.Point(13, 23);
            this.PlayerPositionBtn.Name = "PlayerPositionBtn";
            this.PlayerPositionBtn.ShadowDecoration.Parent = this.PlayerPositionBtn;
            this.PlayerPositionBtn.Size = new System.Drawing.Size(200, 36);
            this.PlayerPositionBtn.TabIndex = 7;
            this.PlayerPositionBtn.Text = "Player Position";
            // 
            // PlayerNameTxtBx
            // 
            this.PlayerNameTxtBx.BorderRadius = 5;
            this.PlayerNameTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PlayerNameTxtBx.DefaultText = "";
            this.PlayerNameTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PlayerNameTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PlayerNameTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlayerNameTxtBx.DisabledState.Parent = this.PlayerNameTxtBx;
            this.PlayerNameTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlayerNameTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlayerNameTxtBx.FocusedState.Parent = this.PlayerNameTxtBx;
            this.PlayerNameTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlayerNameTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlayerNameTxtBx.HoverState.Parent = this.PlayerNameTxtBx;
            this.PlayerNameTxtBx.Location = new System.Drawing.Point(502, 23);
            this.PlayerNameTxtBx.Multiline = true;
            this.PlayerNameTxtBx.Name = "PlayerNameTxtBx";
            this.PlayerNameTxtBx.PasswordChar = '\0';
            this.PlayerNameTxtBx.PlaceholderText = "Player Name";
            this.PlayerNameTxtBx.SelectedText = "";
            this.PlayerNameTxtBx.ShadowDecoration.Parent = this.PlayerNameTxtBx;
            this.PlayerNameTxtBx.Size = new System.Drawing.Size(200, 36);
            this.PlayerNameTxtBx.TabIndex = 6;
            // 
            // PlayerNumberTxtBx
            // 
            this.PlayerNumberTxtBx.BorderRadius = 5;
            this.PlayerNumberTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PlayerNumberTxtBx.DefaultText = "";
            this.PlayerNumberTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PlayerNumberTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PlayerNumberTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlayerNumberTxtBx.DisabledState.Parent = this.PlayerNumberTxtBx;
            this.PlayerNumberTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlayerNumberTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlayerNumberTxtBx.FocusedState.Parent = this.PlayerNumberTxtBx;
            this.PlayerNumberTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlayerNumberTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlayerNumberTxtBx.HoverState.Parent = this.PlayerNumberTxtBx;
            this.PlayerNumberTxtBx.Location = new System.Drawing.Point(259, 23);
            this.PlayerNumberTxtBx.MaxLength = 2;
            this.PlayerNumberTxtBx.Multiline = true;
            this.PlayerNumberTxtBx.Name = "PlayerNumberTxtBx";
            this.PlayerNumberTxtBx.PasswordChar = '\0';
            this.PlayerNumberTxtBx.PlaceholderText = "Player Number";
            this.PlayerNumberTxtBx.SelectedText = "";
            this.PlayerNumberTxtBx.ShadowDecoration.Parent = this.PlayerNumberTxtBx;
            this.PlayerNumberTxtBx.Size = new System.Drawing.Size(200, 36);
            this.PlayerNumberTxtBx.TabIndex = 5;
            this.PlayerNumberTxtBx.TextChanged += new System.EventHandler(this.PlayerNumberTxtBx_TextChanged);
            this.PlayerNumberTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerNumberTxtBx_KeyPress);
            // 
            // TeamPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerPositionBtn);
            this.Controls.Add(this.PlayerNameTxtBx);
            this.Controls.Add(this.PlayerNumberTxtBx);
            this.Name = "TeamPlayerControl";
            this.Size = new System.Drawing.Size(715, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PlayerPositionBtn;
        private Guna.UI2.WinForms.Guna2TextBox PlayerNameTxtBx;
        private Guna.UI2.WinForms.Guna2TextBox PlayerNumberTxtBx;
    }
}
