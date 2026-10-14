/*
 * Created by SharpDevelop.
 * User: a
 * Date: 11/10/2026
 * Time: 07:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Practica
{
	/// <summary>
	/// Description of DatosTarjeta.
	/// </summary>
	public partial class DatosTarjeta : Form
	{
		public DatosTarjeta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
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
		
		void PnlTransparentePaint(object sender, PaintEventArgs e)
		{
		pnlTransparente.BackColor = Color.FromArgb(80, 230, 230, 250);
		}
		
		void PnlInfoPaint(object sender, PaintEventArgs e)
		{
		pnlInfo.BackColor = Color.FromArgb(80, 230, 230, 250);			
		}

		
		
		void BtnSiguienteClick(object sender, EventArgs e)
		{
    	
    	if (!Regex.IsMatch(txtnumeroTarjeta.Text, @"^\d{16}$"))
    	{
        MessageBox.Show("El número de tarjeta debe contener exactamente 16 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    	}

    	
    	if (!Regex.IsMatch(txtCCV.Text, @"^\d{3}$"))
    	{
        MessageBox.Show("El CCV debe contener exactamente 3 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    	}

    	
    	if (!Regex.IsMatch(txtClaveSeguridad.Text, @"^[a-z]{5}$"))
    	{
        MessageBox.Show("La clave de seguridad debe contener exactamente 5 letras minusculas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    	}

    	
    	DatosUsuario.numeroTarjeta = txtnumeroTarjeta.Text;
    	DatosUsuario.CCV = txtCCV.Text;
    	DatosUsuario.claveSeguridad = txtClaveSeguridad.Text;

    	
    	DatosRol Rol = new DatosRol();
    	Rol.Show();
    	this.Hide();
		}
	}
}
