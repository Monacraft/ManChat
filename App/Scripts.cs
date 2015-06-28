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
		void ParseScript(string s)
		{
			if(level <= 2)
			{
				if(s.Split(' ')[0] == "kick")
				{
					try {
						SendMsg(" >> " + username + " was kicked by " + s.Split(' ')[1], false);
					} catch {}
					this.Exit();
				}
			}
		}
	}
}
