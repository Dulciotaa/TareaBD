/*
 * Created by SharpDevelop.
 * User: dulma
 * Date: 09/10/2026
 * Time: 09:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of Administrador.
	/// </summary>
	public partial class Administrador : Form
	{
		public Administrador()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PnlPrincipalPaint(object sender, PaintEventArgs e)
		{
			pnlPrincipal.BackColor = Color.FromArgb(100, 250, 250, 250);
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Empleado Empl = new Empleado();
			Empl.Show();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			Empleado Empl = new Empleado();
			Empl.Show();			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
