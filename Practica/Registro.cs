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
using System.Drawing;
using System.Drawing.Drawing2D;

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
			this.DoubleBuffered = true; 
    
    		this.ResizeRedraw = true;

		}
		
		
		protected override void OnPaintBackground(PaintEventArgs e)
		{
 
    	Rectangle rect = this.ClientRectangle;


    	if (rect.Width == 0 || rect.Height == 0) return;

    	Color colorArriba = Color.FromArgb(135, 206, 235);  
    	Color colorAbajo = Color.FromArgb(25, 25, 112);     

    	using (LinearGradientBrush brush = new LinearGradientBrush(rect, colorArriba, colorAbajo, LinearGradientMode.Vertical))
    {
        e.Graphics.FillRectangle(brush, rect);
    }
}
		
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			panel1.BackColor = Color.FromArgb(80, 230, 230, 250);
		}
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			panel2.BackColor = Color.FromArgb(80, 230, 230, 250);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DatosUsuario.usuario=txtUsuario.Text;
			DatosUsuario.nombre=txtNombre.Text;
			DatosUsuario.apellido=txtApellidos.Text;
			DatosUsuario.correo=txtCorreo.Text;
			DatosUsuario.contraseña=txtContraseña.Text;
			
			DatosDireccion direccion= new DatosDireccion();
			direccion.Show();
			this.Hide();
		}
	}
}
