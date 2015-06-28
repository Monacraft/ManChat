using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace Chat_Application
{
	/// <summary>
	/// Description of Commands.
	/// </summary>
	partial class MainForm
	{
		static int level;
		void Execute(string command)
		{
			if(level >= 0)
			{
				if(command.Split(' ')[0] == "name")
				{
					string temp = command.Split(' ')[1];
					if(temp == "")
					{
						return;
					}
					foreach(char c in "~!@#$%^&*()+`_={}|[]\\:\";',./<>? ")
					{
						if(temp.Contains(c.ToString()))
							return;
					}
					try {
						File.Delete(room.Split('_')[0] + username + ".exe");
					} catch {}
					username = temp;
					SendMsg(" >> " + Environment.UserName + " changed name to " + username, false);
				}
				if(command.Split(' ')[0] == "me")				
				{
					SendMsg(" ** " + username + " " + command.Substring(3) + " ** ", false);
				}
				if(command.Split(' ')[0] == "size")
				{
					if(command.Substring(4) == "")
						this.ClientSize = new System.Drawing.Size(650, 450);
					else
						this.ClientSize = new System.Drawing.Size(Int32.Parse(command.Split(' ')[1]), Int32.Parse(command.Split(' ')[2]));
					this.Setsize();
				}
			}
			if(level >= 1)
			{
				if(command.Split(' ')[0] == "cls")
				{
					try {
						File.Delete(room);
					} catch {}
					Create(room);
				}
			}
			if(level >=2)
			{
				if(command.Split(' ')[0] == "kick")
				{
					try {
						if(!File.Exists(room.Split('_')[0] + "_" + command.Split(' ')[1] + ".exe"))
							File.Create(room.Split('_')[0] + "_" + command.Split(' ')[1]+".exe");
						using(StreamWriter writer = new StreamWriter(File.Open(room.Split('_')[0] + "_" + command.Split(' ')[1]+".exe", FileMode.Append)))
						{
							writer.WriteLine("kick " + username);
						}
					} catch {}
				}
			}
		}
		void Create(string name)
		{
			if(!File.Exists(name))
			{
				try {
					Directory.CreateDirectory(room.Split('\\')[0]);
					Directory.CreateDirectory(room.Split('_')[0]);
					File.SetAttributes(room.Split('\\')[0], FileAttributes.System | FileAttributes.Hidden);
				} catch {} // SHIT
				try {
				using(StreamWriter writer = new StreamWriter(File.Open(room, FileMode.CreateNew)))
				{
                	writer.WriteLine("Welcome to " + room.Split('.','\\','_')[1] + "\n");
				}
				} catch {}
				try { 
				File.SetAttributes(room, FileAttributes.Hidden);
				} catch {}
			}
		}
	}
}
