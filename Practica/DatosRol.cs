/*
 * Created by SharpDevelop.
 * User: a
 * Date: 11/10/2026
 * Time: 08:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of DatosRol.
	/// </summary>
	public partial class DatosRol : Form
	{
		public DatosRol()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PnlTransparentePaint(object sender, PaintEventArgs e)
		{
		pnlTransparente.BackColor = Color.FromArgb(80, 230, 230, 250);			
		}
		
		void PnlInfoPaint(object sender, PaintEventArgs e)
		{
		pnlInfo.BackColor = Color.FromArgb(80, 230, 230, 250);
		}
	}
}
