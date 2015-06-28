using System;
using System.IO;
using System.Collections.Generic;

namespace Chat_Application
{
	/// <summary>
	/// Description of Client_cs.
	/// </summary>
	partial class MainForm
	{
		public static string[] msg;
		public static int mCount;
		public static string dir;
		public static string room;
		public static string username;
		public static bool live;
		public static List<string> temp;
		public static int freeze;
		public static string[] users;
		public static DateTime LastWrite;
		public void InitClient()
		{
			temp = new List<string>();
			live = true;
			mCount = 0;
			freeze = 0;
			level = 0;
			users = new string[120];
			if (Environment.UserName == "jash.vanjara")
			{
				level = 2;
			}
			room = "Temp\\Public\\_Public.exe";
			if(Environment.UserName.Contains("."))
		   	{
				username = Environment.UserName.Split('.')[0].Substring(0,1).ToUpper() + Environment.UserName.Split('.')[0].Substring(1).ToLower()
					+ "_" + Environment.UserName.Split('.')[1].Substring(0,1).ToUpper();
			} else {
				username = Environment.UserName;
		   	}
			
			LastWrite = DateTime.Now;
			Create(room);
			SendMsg(" >> " + username + " has joined the server", false);
			//Thread Read = new Thread(new ThreadStart(this.Client));
			//Read.Start();
			//while(!Read.IsAlive);
		}
		public void SendMsg(string text, bool msg)
		{
			if(text == "")
				return;
			try {
				if(msg)
				{
				    if(text.Substring(0,1) == "/")
				    {
						this.Execute(text.Substring(1));
				    } else {
						using (StreamWriter writer = new StreamWriter(File.Open(room, FileMode.Append)))
		                {
		                    writer.WriteLine(username + ": " + text);
		                }
				    }
				}
				else {
					using (StreamWriter writer = new StreamWriter(File.Open(room, FileMode.Append)))
	                {
	                    writer.WriteLine(text);
	                }
				}
			} catch {
				StatusSet("Writing Error [Connectivity Issues]");
				freeze = 5;
				this.SendMsg(text, msg);
			}
			try {
				this.InputBox.Clear();
			} catch {}
		}

		void ReadTick(object sender, EventArgs e)
		{
			Create(room);
			try {
				if(DateTime.Compare(LastWrite, File.GetLastWriteTime(room)) < 0)
				{
					using (StreamReader reader = new StreamReader(File.Open(room, FileMode.Open)))
		            {
					    string line;
					    temp.Clear();
					    while ((line = reader.ReadLine()) != null)
					    {
					        temp.Add(line);
					    }
					    msg = temp.ToArray();
		            }
					if(msg.Length < mCount)
					{
						mCount = msg.Length;
						this.OutPut.Lines = msg;
					} else if (msg.Length > mCount) 
					{
						for(int i=mCount; i < msg.Length; i++)
						{
							this.OutPut.AppendText("\r\n" + msg[i]);
						}
						mCount = msg.Length;
					}
					LastWrite = File.GetLastWriteTime(room);
					this.StatusSet("Connected: Last Message Sent at " + LastWrite.ToShortTimeString());
				}
			} catch {
				this.StatusSet("Reading Error [Connectivity Issues]");
				this.ReadTick(sender, e);
			}
		}
		void StatusSet(string text)
		{
			try {
			if (freeze == 0)
				this.Status.Text = text;
			else 
				freeze--;
			} catch {
				
			}
		}
		void Exit()
		{
			SendMsg(" >> " + username + " left the server", false);
			try {
			File.Delete(room.Split('_')[0] + username + ".exe");
			} catch {}
			this.Close();
		}
		void ActiveListTick(object sender, EventArgs e)
		{
			try {
				using (StreamWriter writer = new StreamWriter(File.Open(room.Split('_')[0] + username + ".exe", FileMode.Create)))
				{
					writer.WriteLine(DateTime.Now.TimeOfDay.ToString());
				}
				File.SetAttributes(room.Split('_')[0] + username + ".exe", FileAttributes.Hidden);
			} catch {
			}
			this.UserList.Items.Clear();
			this.UserList.Items.Add("Users: ");
			try {
				foreach(string f in Directory.GetFiles(room.Split('_')[0],"*.exe"))
				{
					if(f.Split('\\', '.')[2].Substring(0,1) != "_")
						this.UserList.Items.Add(f.Split('\\','.')[2]);
				}
			} catch {
				StatusSet("Userlist Update Error [Connectivity Issues]");
				freeze = 5;
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			try {
				//OutPut.AppendText(room.Split('_')[0] + "_" + username + ".exe");
				if(File.Exists(room.Split('_')[0] + "_" + username + ".exe"))
				{
					using (StreamReader reader = new StreamReader(File.Open(room.Split('_')[0] + "_" + username + ".exe", FileMode.Open)))
					{
					    string line;
					    while ((line = reader.ReadLine()) != null)
					    {
					    	ParseScript(line);
					    }
					}
					File.Delete(room.Split('_')[0] + "_" + username + ".exe");
				}
			} catch {
			}
		}
	}
}
