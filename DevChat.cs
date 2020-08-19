/*
 * Created by SharpDevelop.
 * User: casper
 * Date: 6.08.2020
 * Time: 00:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tridiModellerThingy
{
	/// <summary>
	/// Description of DevChat.
	/// </summary>
	public partial class DevChat : Form
	{
		
		string data;
		public DevChat()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
                   	async void yourMethod()
{
                   		string placeholder;
                   		using (var wc = new System.Net.WebClient())
	placeholder= await wc.DownloadStringTaskAsync("https://datastatic.bricktale.xyz/devchat/chat.chat");
                   		
                   		
                   		string test = placeholder.ToLower();
                   		string censor = test.Replace("fuck","****").Replace("fak","****").Replace("shit","****").Replace("go commit sucidie","****").Replace("bitch","****").Replace("b!tch","****").Replace("bidch","****").Replace("fag","****").Replace("ffff","****").Replace("mother","****").Replace("shit","****").Replace("sheet","****").Replace("fu ck","****").Replace("f uck","****").Replace("fuc k","****").Replace("$hit","****").Replace("nigger","I AM AN RACIST!!!").Replace("Wigger","well still im an racist").Replace("Koyim","Ban yedin gerizekalığğğğğğ").Replace("sik","olmaz olsun böyle yazı").Replace("corona","cough cough");
                   		richTextBox2.Text = censor;
                   		
                   	}

                   		
		void Timer1Tick(object sender, EventArgs e)
		{

			yourMethod();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
using (var wc = new System.Net.WebClient())
	data = wc.DownloadString(String.Format("https://datastatic.bricktale.xyz/devchat/chat.php?chat={0}%20{1}\n",richTextBox1.Text,textBox2.Text));
		}
		
	
		
		void Timer2Tick(object sender, EventArgs e)
		{
		
		}
	}
}
