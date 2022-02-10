using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MantlePresenceGUI.Handler;

namespace MantlePresenceGUI
{
    public partial class Frm : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public string Link = "https://mantle.gg/account";

        public string Auth;

        public static string[] CapeArr = new string[] { };

        public Frm()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            //browserPnl.Hide();
            checkProcess();
            Discord.DiscordID();
            Discord.Start();
        }

        private void addAuthbtn_Click(object sender, EventArgs e)
        {
            Auth = authTxtBox.Text;
            MantleAuth();
        }

        private void checkCapesBtn_Click(object sender, EventArgs e)
        {
            //refresh page once more just in case
            chromeBrowser.ExecuteScriptAsync("window.location.reload();");
            MantleReader();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Discord.Close();
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void checkProcess()
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("Mantle");
                if (proc.Length == 0)
                {
                    MessageBox.Show("Mantle.gg is not running. Please restart the app for Discord Presence to work!", Application.ProductName);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured. Error: {ex.Message}", Application.ProductName);
            }
        }

        public void InitializeChromium()
        {
            try
            {
                CefSettings settings = new CefSettings();
                // Initialize cef with the provided settings
                Cef.Initialize(settings);
                // Create a browser component
                chromeBrowser = new ChromiumWebBrowser(Link);
                // Add it to the form and fill it to the game panel
                browserPnl.Controls.Add(chromeBrowser);
                chromeBrowser.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem initializing chromium, error: {ex.Message}", Application.ProductName);
            }
        }

        public void MantleAuth()
        {
            try
            {
                chromeBrowser.ExecuteScriptAsync($"document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.auth = `{Auth}`");
                chromeBrowser.ExecuteScriptAsync("window.location.reload();");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error setting the auth code for mantle.gg. Error: {ex.Message}");
            }
        }
        
        public void MantleReader()
        {
            string src = chromeBrowser.GetSourceAsync().Result;

            if (src.Contains("Black"))
            {
                CapeArr = new List<string>(CapeArr) { "Black Cape" }.ToArray();
            }
            if (src.Contains("NameMC Vote"))
            {
                CapeArr = new List<string>(CapeArr) { "NameMc Cape" }.ToArray();
            }
            var List = (string.Join(", ", CapeArr));
            Discord.Update("Using Mantle capes", $"Capes in account: {List.ToString()}");
            MessageBox.Show($"Items detected: {List}", Application.ProductName);
        }
    }
}
