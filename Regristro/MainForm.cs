/*
 * Created by SharpDevelop.
 * User: a
 * Date: 07/10/2026
 * Time: 10:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Regristro
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
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			panel1.BackColor = Color.FromArgb(80, 230, 230, 250);
			
		}
	}
}
