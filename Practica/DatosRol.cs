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
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

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
		
		void BtnRegistrarClick(object sender, EventArgs e) {
    		DatosUsuario.sueldo = int.Parse(txtSueldo.Text);
    		string rolUsuario = listBoxRol.SelectedItem.ToString();
    		DatosUsuario.rol = rolUsuario;

	string conexionStr = "Server=practica.mysql.database.azure.com;Port=3306;Database=practicalogin;Uid=ivarodul;Pwd=13579135Ca;SslMode=none;";
	
    string query = @"INSERT INTO usuarios 
                    (usuario, nombre, apellido, correo, contraseña, ciudad, calle, colonia, turno, numeroTarjeta, ccv, claveSeguridad, sueldo, rol) 
                    VALUES 
                    (@usuario, @nombre, @apellido, @correo, sha2(@contrasena, 256), @ciudad, @calle, @colonia, @turno, AES_ENCRYPT(@numeroTarjeta, 'ivarodul'), AES_ENCRYPT(@ccv, 'ivarodul'), AES_ENCRYPT(@claveSeguridad, 'ivarodul'), @sueldo, @rol)";

    try
    {
        using (MySqlConnection conexion = new MySqlConnection(conexionStr))
        {
            conexion.Open();
            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {

                comando.Parameters.AddWithValue("@usuario", DatosUsuario.usuario);
                comando.Parameters.AddWithValue("@nombre", DatosUsuario.nombre);
                comando.Parameters.AddWithValue("@apellido", DatosUsuario.apellido);
                comando.Parameters.AddWithValue("@correo", DatosUsuario.correo);
                
                
                comando.Parameters.AddWithValue("@contrasena", DatosUsuario.contraseña);
                
                comando.Parameters.AddWithValue("@ciudad", DatosUsuario.ciudad);
                comando.Parameters.AddWithValue("@calle", DatosUsuario.calle);
                comando.Parameters.AddWithValue("@colonia", DatosUsuario.colonia);
                comando.Parameters.AddWithValue("@turno", DatosUsuario.turno);
                
                comando.Parameters.AddWithValue("@numeroTarjeta", DatosUsuario.numeroTarjeta);
                comando.Parameters.AddWithValue("@ccv", DatosUsuario.CCV);
                comando.Parameters.AddWithValue("@claveSeguridad", DatosUsuario.claveSeguridad);
                
                comando.Parameters.AddWithValue("@sueldo", DatosUsuario.sueldo);
                comando.Parameters.AddWithValue("@rol", DatosUsuario.rol);

                
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("¡Usuario registrado con éxito!");
                    
                }
            }
        }
    }
    catch (MySqlException ex)
    {
        MessageBox.Show("Error de base de datos: " + ex.Message);
    }
    catch (System.Exception ex)
    {
        MessageBox.Show("Ocurrió un error: " + ex.Message);
    }
    
    	Administrador admin= new Administrador();
		admin.Show();
		
		this.Hide();
    
    
			}
		
		
		
		
	}
}
