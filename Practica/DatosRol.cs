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
		
		void BtnRegistrarClick(object sender, EventArgs e) {
    // 1. Guardar los últimos datos de esta ventana (como ya lo tenías)
    		DatosUsuario.sueldo = int.Parse(txtSueldo.Text);
    		string rolUsuario = listBoxRol.SelectedItem.ToString();
    		DatosUsuario.rol = rolUsuario;

    // 2. Configurar la conexión (Cambia "tu_base_de_datos" y "tu_contraseña" por los reales)
	string conexionStr = "Server=practica.mysql.database.azure.com;Port=3306;Database=practicalogin;Uid=ivarodul;Pwd=13579135Ca;SslMode=none;";

    // 3. Crear la consulta INSERT
    // Usamos AES_ENCRYPT para los 4 campos BLOB usando 'llave123' como contraseña de encriptación
    string query = @"INSERT INTO usuarios 
                    (usuario, nombre, apellido, correo, contraseña, ciudad, calle, colonia, turno, numeroTarjeta, ccv, claveSeguridad, sueldo, rol) 
                    VALUES 
                    (@usuario, @nombre, @apellido, @correo, AES_ENCRYPT(@contrasena, 'llave123'), @ciudad, @calle, @colonia, @turno, AES_ENCRYPT(@numeroTarjeta, 'llave123'), AES_ENCRYPT(@ccv, 'llave123'), AES_ENCRYPT(@claveSeguridad, 'llave123'), @sueldo, @rol)";

    try
    {
        using (MySqlConnection conexion = new MySqlConnection(conexionStr))
        {
            conexion.Open();
            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                // 4. Asignar todos los parámetros desde tu clase estática DatosUsuario
                comando.Parameters.AddWithValue("@usuario", DatosUsuario.usuario);
                comando.Parameters.AddWithValue("@nombre", DatosUsuario.nombre);
                comando.Parameters.AddWithValue("@apellido", DatosUsuario.apellido);
                comando.Parameters.AddWithValue("@correo", DatosUsuario.correo);
                
                // Nota: Usamos @contrasena sin 'ñ' en el parámetro SQL para evitar problemas de codificación, 
                // pero sí le pasamos tu variable DatosUsuario.contraseña
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

                // 5. Ejecutar el insert
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("¡Usuario registrado con éxito!");
                    // Aquí puedes cerrar el programa o reiniciar las ventanas si lo deseas
                    // Application.Exit(); 
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
			}
		
		
		
		
	}
}
