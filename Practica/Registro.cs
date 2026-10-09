/*
 * Created by SharpDevelop.
 * User: a
 * Date: 08/10/2026
 * Time: 07:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of Registro.
	/// </summary>
	public partial class Registro : Form
	{
		public Registro()
		{

			InitializeComponent();

		}
		
		void RegistroLoad(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			panel1.BackColor = Color.FromArgb(80, 230, 230, 250);
		}
	}
}
