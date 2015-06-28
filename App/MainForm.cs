using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chat_Application
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitClient();
			InitializeComponent();
			this.ClientSize = new System.Drawing.Size(900, 550);
			this.Setsize();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			//if(e.Control && e.KeyData == Keys.Z)
			//{
			//	this.MinimizeClick(sender, EventArgs.Empty);
			//}
		}
	}
}
