namespace MantlePresenceGUI
{
    partial class Frm
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
            this.browserPnl = new System.Windows.Forms.Panel();
            this.authTxtBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.addAuthbtn = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // browserPnl
            // 
            this.browserPnl.Location = new System.Drawing.Point(56, 12);
            this.browserPnl.Name = "browserPnl";
            this.browserPnl.Size = new System.Drawing.Size(506, 240);
            this.browserPnl.TabIndex = 0;
            // 
            // authTxtBox
            // 
            this.authTxtBox.Animated = false;
            this.authTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.authTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.authTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authTxtBox.DefaultText = "";
            this.authTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.authTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.authTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authTxtBox.DisabledState.Parent = this.authTxtBox;
            this.authTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.authTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authTxtBox.FocusedState.Parent = this.authTxtBox;
            this.authTxtBox.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.authTxtBox.ForeColor = System.Drawing.Color.White;
            this.authTxtBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authTxtBox.HoveredState.Parent = this.authTxtBox;
            this.authTxtBox.Location = new System.Drawing.Point(14, 297);
            this.authTxtBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.authTxtBox.Name = "authTxtBox";
            this.authTxtBox.PasswordChar = '\0';
            this.authTxtBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.authTxtBox.PlaceholderText = "";
            this.authTxtBox.SelectedText = "";
            this.authTxtBox.ShadowDecoration.Parent = this.authTxtBox;
            this.authTxtBox.Size = new System.Drawing.Size(283, 37);
            this.authTxtBox.TabIndex = 9;
            // 
            // addAuthbtn
            // 
            this.addAuthbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addAuthbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addAuthbtn.BorderRadius = 4;
            this.addAuthbtn.BorderThickness = 2;
            this.addAuthbtn.CheckedState.Parent = this.addAuthbtn;
            this.addAuthbtn.CustomImages.Parent = this.addAuthbtn;
            this.addAuthbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addAuthbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addAuthbtn.ForeColor = System.Drawing.Color.White;
            this.addAuthbtn.HoveredState.Parent = this.addAuthbtn;
            this.addAuthbtn.Location = new System.Drawing.Point(318, 297);
            this.addAuthbtn.Name = "addAuthbtn";
            this.addAuthbtn.ShadowDecoration.Parent = this.addAuthbtn;
            this.addAuthbtn.Size = new System.Drawing.Size(111, 37);
            this.addAuthbtn.TabIndex = 15;
            this.addAuthbtn.Text = "Add Auth";
            this.addAuthbtn.Click += new System.EventHandler(this.addAuthbtn_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(626, 349);
            this.Controls.Add(this.addAuthbtn);
            this.Controls.Add(this.authTxtBox);
            this.Controls.Add(this.browserPnl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantle Presence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel browserPnl;
        private Siticone.UI.WinForms.SiticoneTextBox authTxtBox;
        public Siticone.UI.WinForms.SiticoneButton addAuthbtn;
    }
}

