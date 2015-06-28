using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Chat_Application
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param room="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TitleBar = new System.Windows.Forms.Label();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.Minimize = new System.Windows.Forms.Button();
			this.LeftBar = new System.Windows.Forms.Label();
			this.RightBar = new System.Windows.Forms.Label();
			this.BottomBar = new System.Windows.Forms.Label();
			this.OutPut = new System.Windows.Forms.TextBox();
			this.InputBox = new System.Windows.Forms.TextBox();
			this.Send = new System.Windows.Forms.Button();
			this.MenuList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showInTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideInTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TaskTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.Reader = new System.Windows.Forms.Timer(this.components);
			this.Commands = new System.IO.FileSystemWatcher();
			this.Status = new System.Windows.Forms.Label();
			this.UserList = new System.Windows.Forms.ListBox();
			this.ActiveList = new System.Windows.Forms.Timer(this.components);
			this.SelfCommand = new System.Windows.Forms.Timer(this.components);
			this.MenuList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.TitleBar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.TitleBar.Image = global::Chat_Application.Client.Logo_Image;
			this.TitleBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(290, 30);
			this.TitleBar.TabIndex = 5;
			this.TitleBar.Text = "Man Chat";
			this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseDown);
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.Red;
			this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseBtn.ForeColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(321, 1);
			this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(28, 28);
			this.CloseBtn.TabIndex = 4;
			this.CloseBtn.Text = "X";
			this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseClick);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.Black;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Minimize.ForeColor = System.Drawing.Color.White;
			this.Minimize.Location = new System.Drawing.Point(288, 1);
			this.Minimize.Margin = new System.Windows.Forms.Padding(0);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(32, 28);
			this.Minimize.TabIndex = 3;
			this.Minimize.Text = "----";
			this.Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.MinimizeClick);
			// 
			// LeftBar
			// 
			this.LeftBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LeftBar.ForeColor = System.Drawing.Color.Black;
			this.LeftBar.Location = new System.Drawing.Point(0, 30);
			this.LeftBar.Name = "LeftBar";
			this.LeftBar.Size = new System.Drawing.Size(5, 415);
			this.LeftBar.TabIndex = 2;
			// 
			// RightBar
			// 
			this.RightBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.RightBar.ForeColor = System.Drawing.Color.Black;
			this.RightBar.Location = new System.Drawing.Point(345, 30);
			this.RightBar.Name = "RightBar";
			this.RightBar.Size = new System.Drawing.Size(5, 415);
			this.RightBar.TabIndex = 1;
			// 
			// BottomBar
			// 
			this.BottomBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BottomBar.ForeColor = System.Drawing.Color.Black;
			this.BottomBar.Location = new System.Drawing.Point(0, 445);
			this.BottomBar.Name = "BottomBar";
			this.BottomBar.Size = new System.Drawing.Size(350, 5);
			this.BottomBar.TabIndex = 6;
			// 
			// OutPut
			// 
			this.OutPut.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.OutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutPut.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutPut.Location = new System.Drawing.Point(5, 56);
			this.OutPut.MaxLength = 9999999;
			this.OutPut.Multiline = true;
			this.OutPut.Name = "OutPut";
			this.OutPut.ReadOnly = true;
			this.OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.OutPut.ShortcutsEnabled = false;
			this.OutPut.Size = new System.Drawing.Size(340, 385);
			this.OutPut.TabIndex = 10;
			this.OutPut.Text = "Normo\'s Chat App";
			// 
			// InputBox
			// 
			this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InputBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputBox.Location = new System.Drawing.Point(5, 415);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(300, 30);
			this.InputBox.TabIndex = 0;
			this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
			// 
			// Send
			// 
			this.Send.BackColor = System.Drawing.Color.Red;
			this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Send.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Send.Image = global::Chat_Application.Client.Logo_Image;
			this.Send.Location = new System.Drawing.Point(305, 415);
			this.Send.Margin = new System.Windows.Forms.Padding(0);
			this.Send.Name = "Send";
			this.Send.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Send.Size = new System.Drawing.Size(40, 30);
			this.Send.TabIndex = 1;
			this.Send.UseVisualStyleBackColor = false;
			this.Send.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SendMouseClick);
			// 
			// MenuList
			// 
			this.MenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.showInTaskbarToolStripMenuItem,
									this.hideInTaskbarToolStripMenuItem,
									this.closeToolStripMenuItem});
			this.MenuList.Name = "contextMenuStrip1";
			this.MenuList.Size = new System.Drawing.Size(161, 92);
			// 
			// showInTaskbarToolStripMenuItem
			// 
			this.showInTaskbarToolStripMenuItem.Name = "showInTaskbarToolStripMenuItem";
			this.showInTaskbarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.showInTaskbarToolStripMenuItem.Text = "Show in Taskbar";
			this.showInTaskbarToolStripMenuItem.Click += new System.EventHandler(this.ShowInTaskbarToolStripMenuItemClick);
			// 
			// hideInTaskbarToolStripMenuItem
			// 
			this.hideInTaskbarToolStripMenuItem.Name = "hideInTaskbarToolStripMenuItem";
			this.hideInTaskbarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.hideInTaskbarToolStripMenuItem.Text = "Hide in Taskbar";
			this.hideInTaskbarToolStripMenuItem.Click += new System.EventHandler(this.HideInTaskbarToolStripMenuItemClick);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
			// 
			// TaskTray
			// 
			this.TaskTray.ContextMenuStrip = this.MenuList;
			this.TaskTray.Icon = global::Chat_Application.Client.Logo_Icon;
			this.TaskTray.Text = "ChatApp";
			this.TaskTray.Visible = true;
			this.TaskTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskTrayMouseClick);
			// 
			// Reader
			// 
			this.Reader.Enabled = true;
			this.Reader.Interval = 250;
			this.Reader.Tick += new System.EventHandler(this.ReadTick);
			// 
			// Commands
			// 
			this.Commands.EnableRaisingEvents = true;
			this.Commands.Filter = "public.chat";
			this.Commands.NotifyFilter = System.IO.NotifyFilters.FileName;
			this.Commands.SynchronizingObject = this;
			// 
			// Status
			// 
			this.Status.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Status.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Status.Location = new System.Drawing.Point(5, 30);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(340, 25);
			this.Status.TabIndex = 11;
			this.Status.Text = "Not Connected";
			// 
			// UserList
			// 
			this.UserList.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.UserList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserList.FormattingEnabled = true;
			this.UserList.IntegralHeight = false;
			this.UserList.ItemHeight = 22;
			this.UserList.Items.AddRange(new object[] {
									"Users"});
			this.UserList.Location = new System.Drawing.Point(5, 55);
			this.UserList.Name = "UserList";
			this.UserList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.UserList.Size = new System.Drawing.Size(100, 70);
			this.UserList.TabIndex = 12;
			// 
			// ActiveList
			// 
			this.ActiveList.Enabled = true;
			this.ActiveList.Interval = 250;
			this.ActiveList.Tick += new System.EventHandler(this.ActiveListTick);
			// 
			// SelfCommand
			// 
			this.SelfCommand.Enabled = true;
			this.SelfCommand.Interval = 300;
			this.SelfCommand.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(350, 450);
			this.Controls.Add(this.UserList);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.InputBox);
			this.Controls.Add(this.Send);
			this.Controls.Add(this.OutPut);
			this.Controls.Add(this.BottomBar);
			this.Controls.Add(this.RightBar);
			this.Controls.Add(this.LeftBar);
			this.Controls.Add(this.Minimize);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.TitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = global::Chat_Application.Client.Logo_Icon;
			this.Name = "MainForm";
			this.Text = "Man Chat";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.MenuList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer SelfCommand;
		private System.Windows.Forms.Timer ActiveList;
		private System.Windows.Forms.ListBox UserList;
		private System.Windows.Forms.Label Status;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.IO.FileSystemWatcher Commands;
		private System.Windows.Forms.ToolStripMenuItem hideInTaskbarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showInTaskbarToolStripMenuItem;
		private System.Windows.Forms.Timer Reader;
		private System.Windows.Forms.NotifyIcon TaskTray;
		private System.Windows.Forms.ContextMenuStrip MenuList;
		private System.Windows.Forms.Button Send;
		private System.Windows.Forms.TextBox InputBox;
		private System.Windows.Forms.TextBox OutPut;
		private System.Windows.Forms.Label BottomBar;
		private System.Windows.Forms.Label RightBar;
		private System.Windows.Forms.Label LeftBar;
		private System.Windows.Forms.Button Minimize;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.Label TitleBar;
		
		void CloseClick(object sender, System.EventArgs e)
		{
			this.Exit();
		}
		
		void TaskTrayMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				if(this.ShowInTaskbar)
				{
					if(this.WindowState == FormWindowState.Minimized)
						this.WindowState = FormWindowState.Normal;
					else 
						this.WindowState = FormWindowState.Minimized;
				} else {
					this.Show();
					this.Focus();
					this.Activate();
				}
			}
			else if (e.Button == MouseButtons.Middle)
			{
				this.CloseClick(sender, EventArgs.Empty);
			}
		}
		void SendMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.SendMsg(this.InputBox.Text, true);
		}
		
		void InputBoxKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				this.SendMsg(this.InputBox.Text, true);
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		void TitleBarMouseDown(object sender, MouseEventArgs e)
		{
		    if (e.Button == MouseButtons.Left)
		    {
		        ReleaseCapture();
		        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		    }
		}
		const int WS_MINIMIZEBOX = 0x20000;
		const int CS_DBLCLKS = 0x8;
		protected override CreateParams CreateParams
		{
		    get
		    {
		        CreateParams cp = base.CreateParams;
		        cp.Style |= WS_MINIMIZEBOX;
		        cp.ClassStyle |= CS_DBLCLKS;
		        return cp;
		    }
		}
		void Setsize()
		{
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Size = new System.Drawing.Size(this.Width - 10, 30);
			this.CloseBtn.Location = new System.Drawing.Point(this.Width - 39, 2);
			this.CloseBtn.Size = new System.Drawing.Size(33, 26);
			this.Minimize.Location = new System.Drawing.Point(this.Width - 77, 2);
			this.Minimize.Size = new System.Drawing.Size(36, 26);
			this.LeftBar.Location = new System.Drawing.Point(0, 30);
			this.LeftBar.Size = new System.Drawing.Size(5, this.Height-35);
			this.RightBar.Location = new System.Drawing.Point(this.Width-5, 30);
			this.RightBar.Size = new System.Drawing.Size(5, this.Height-35);
			this.BottomBar.Location = new System.Drawing.Point(0, this.Height - 5);
			this.BottomBar.Size = new System.Drawing.Size(this.Width, 5);
			this.OutPut.Location = new System.Drawing.Point(5, 55);
			this.OutPut.Size = new System.Drawing.Size(this.Width-190, this.Height-91);
			this.InputBox.Location = new System.Drawing.Point(5, this.Height-35);
			this.InputBox.Size = new System.Drawing.Size(this.Width-50, 30);    //Change Height To 30
			this.Send.Location = new System.Drawing.Point(this.Width-45, this.Height-35);
			this.Send.Size = new System.Drawing.Size(41, 30);  // Height
			this.Status.Location = new System.Drawing.Point(5, 30);
			this.Status.Size = new System.Drawing.Size(this.Width - 10, 24);
			this.UserList.Location = new System.Drawing.Point(this.Width-184, 55);
			this.UserList.Size = new System.Drawing.Size(180, this.Height-91);
		}
		void ShowInTaskbarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Show();
			this.Focus();
			this.Activate();
			this.ShowInTaskbar = true;
			((ToolStripMenuItem)this.MenuList.Items[0]).Checked = true;
			((ToolStripMenuItem)this.MenuList.Items[1]).Checked = false;
			
		}
		
		void HideInTaskbarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.ShowInTaskbar = false;
			((ToolStripMenuItem)this.MenuList.Items[0]).Checked = false;
			((ToolStripMenuItem)this.MenuList.Items[1]).Checked = true;
		}
		
		void MinimizeClick(object sender, EventArgs e)
		{
				if(this.ShowInTaskbar)
				{
					this.WindowState = FormWindowState.Minimized;
				} else {
					this.Hide();
				}
		}
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.CloseClick(sender, e);
		}
	}
}
