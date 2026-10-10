/*
 * Created by SharpDevelop.
 * User: dulma
 * Date: 09/10/2026
 * Time: 10:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public partial class Empleado : Form
	{
		public Empleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PnlCentralPaint(object sender, PaintEventArgs e)
		{
			pnlCentral.BackColor = Color.FromArgb(100, 250, 250, 250);			
		}
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
