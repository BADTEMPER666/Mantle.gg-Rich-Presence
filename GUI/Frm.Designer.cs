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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.browserPnl = new System.Windows.Forms.Panel();
            this.authTxtBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.addAuthbtn = new Siticone.UI.WinForms.SiticoneButton();
            this.checkCapesBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.topPnl = new System.Windows.Forms.Panel();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserPnl
            // 
            this.browserPnl.Location = new System.Drawing.Point(32, 132);
            this.browserPnl.Name = "browserPnl";
            this.browserPnl.Size = new System.Drawing.Size(318, 152);
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
            this.authTxtBox.Location = new System.Drawing.Point(14, 69);
            this.authTxtBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.authTxtBox.Name = "authTxtBox";
            this.authTxtBox.PasswordChar = '\0';
            this.authTxtBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.authTxtBox.PlaceholderText = "Auth String";
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
            this.addAuthbtn.Location = new System.Drawing.Point(305, 69);
            this.addAuthbtn.Name = "addAuthbtn";
            this.addAuthbtn.ShadowDecoration.Parent = this.addAuthbtn;
            this.addAuthbtn.Size = new System.Drawing.Size(111, 37);
            this.addAuthbtn.TabIndex = 15;
            this.addAuthbtn.Text = "Add Auth";
            this.addAuthbtn.Click += new System.EventHandler(this.addAuthbtn_Click);
            // 
            // checkCapesBtn
            // 
            this.checkCapesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.checkCapesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.checkCapesBtn.BorderRadius = 4;
            this.checkCapesBtn.BorderThickness = 2;
            this.checkCapesBtn.CheckedState.Parent = this.checkCapesBtn;
            this.checkCapesBtn.CustomImages.Parent = this.checkCapesBtn;
            this.checkCapesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.checkCapesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkCapesBtn.ForeColor = System.Drawing.Color.White;
            this.checkCapesBtn.HoveredState.Parent = this.checkCapesBtn;
            this.checkCapesBtn.Location = new System.Drawing.Point(390, 247);
            this.checkCapesBtn.Name = "checkCapesBtn";
            this.checkCapesBtn.ShadowDecoration.Parent = this.checkCapesBtn;
            this.checkCapesBtn.Size = new System.Drawing.Size(111, 37);
            this.checkCapesBtn.TabIndex = 16;
            this.checkCapesBtn.Text = "Check Capes";
            this.checkCapesBtn.Click += new System.EventHandler(this.checkCapesBtn_Click);
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(504, 35);
            this.topPnl.TabIndex = 29;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(456, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(405, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 22;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantle.gg presence";
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(504, 296);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.checkCapesBtn);
            this.Controls.Add(this.addAuthbtn);
            this.Controls.Add(this.authTxtBox);
            this.Controls.Add(this.browserPnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantle Presence";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel browserPnl;
        private Siticone.UI.WinForms.SiticoneTextBox authTxtBox;
        public Siticone.UI.WinForms.SiticoneButton addAuthbtn;
        public Siticone.UI.WinForms.SiticoneButton checkCapesBtn;
        private System.Windows.Forms.Panel topPnl;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
    }
}

