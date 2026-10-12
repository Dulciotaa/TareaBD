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
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica
{
	/// <summary>
	/// Description of Administrador.
	/// </summary>
	public partial class Administrador : Form
	{
	void CargarDatos()
        {
            string cadenaConexion = "Server=practica.mysql.database.azure.com; Port=3306; Database=practicalogin; Uid=ivarodul; Pwd=13579135Ca; SslMode=None;";
           
            string consulta = "SELECT usuario, nombre, apellido, correo, CAST(`contraseña` AS CHAR(50)), ciudad, calle, colonia, turno, CAST(AES_DECRYPT(numeroTarjeta, 'ivarodul') AS CHAR(16)) AS numeroTarjeta, CAST(AES_DECRYPT(ccv, 'ivarodul') AS CHAR(3)) as CCV,  CAST(AES_DECRYPT(claveSeguridad, 'ivarodul') AS CHAR(5)) as Clave, fechaCreacion, sueldo, rol FROM usuarios";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string configCharset = "SET character_set_client = utf8, character_set_connection = utf8, character_set_results = latin1;";
                    MySqlCommand cmdSet = new MySqlCommand(configCharset, conexion);
            		cmdSet.ExecuteNonQuery();
                   

                    MySqlDataAdapter adapt = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adapt.Fill(tabla);

                    dtGVTablaUsers.DataSource = null;
                    dtGVTablaUsers.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con MySQL: " + ex.Message);
                }
            }
        }
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
			
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Registro reg = new Registro();
			reg.Show();
			this.SetVisibleCore(false);
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
			MainForm main = new MainForm();
			main.Show();
			this.Close();
			
		}
		void AdministradorLoad(object sender, EventArgs e)
		{
		    CargarDatos();
		    pnlPrincipal.BackColor = Color.FromArgb(100, 250, 250, 250);
		}
	}
}
