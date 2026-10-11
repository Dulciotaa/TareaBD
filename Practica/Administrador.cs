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
using System.Data.SqlClient;

namespace Practica
{
	/// <summary>
	/// Description of Administrador.
	/// </summary>
	public partial class Administrador : Form
	{
			void CargarDatos(){
		    string cadenaConexion = "Server=tcp:tu_servidor.database.windows.net,1433;Initial Catalog=tu_base_de_datos;User ID=tu_usuario;Password=tu_contraseña;Encrypt=True;";
		    string consulta = "SELECT * FROM Usuarios";
		
		    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
		    {
		        try
		        {
		            
		            SqlDataAdapter adapt = new SqlDataAdapter(consulta, conexion);
		            DataTable tabla = new DataTable();
		            adapt.Fill(tabla);
		            dtGVTablaUsers.DataSource = tabla;
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Error al conectar con : " + ex.Message);
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
			pnlPrincipal.BackColor = Color.FromArgb(100, 250, 250, 250);
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
			this.Hide();
			
		}
	}
}
