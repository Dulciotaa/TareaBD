/*
 * Created by SharpDevelop.
 * User: a
 * Date: 09/10/2026
 * Time: 09:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Practica
{
	/// <summary>
	/// Description of DatosDireccion.
	/// </summary>
	public partial class DatosDireccion : Form
	{
		public DatosDireccion()
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
	}
	
	
	
	
	
}
