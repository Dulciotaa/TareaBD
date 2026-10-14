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
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public partial class Empleado : Form
	{
		string usuarioLogueado;
		
	void CargarDatos()
        {
            string cadenaConexion = "Server=practica.mysql.database.azure.com; Port=3306; Database=practicalogin; Uid=ivarodul; Pwd=13579135Ca; SslMode=None;";

            string consulta = "SELECT usuario, nombre, apellido, correo, ciudad, calle, colonia, turno, fechaCreacion, sueldo, rol FROM usuarios";

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
		public Empleado(String usuario)
		{
				usuarioLogueado = usuario;			

			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PnlCentralPaint(object sender, PaintEventArgs e)
		{
						
		}
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
            this.Hide();
		}
		
		void EmpleadoLoad(object sender, EventArgs e)
		{
			dtGVTablaUsers.ReadOnly = true;
			dtGVTablaUsers.AllowUserToAddRows = false;
			dtGVTablaUsers.AllowUserToDeleteRows = false;
			pnlCentral.BackColor = Color.FromArgb(100, 250, 250, 250);
			lblMostrUsuario.Text = "Bienvenido " + usuarioLogueado;
            
            
            CargarDatos();
		}
	}
}
