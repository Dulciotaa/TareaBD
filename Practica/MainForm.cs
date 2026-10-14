/*
 * Created by SharpDevelop.
 * User: a
 * Date: 07/10/2026
 * Time: 10:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			string rol = cmbRol.Text; 
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string dbUser="ivarodul";
            string dbcon="13579135Ca";
            
           

            string cadenaConexion = "Server=practica.mysql.database.azure.com; Port=3306; Database=practicalogin; Uid=" + dbUser + "; Pwd="+dbcon+"; SslMode=None;";
            
            
           	string consulta = "SELECT COUNT(*) FROM usuarios WHERE usuario = @user AND `contraseña` = SHA2(@pass, 256) AND rol = @rol";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    MySqlCommand cmdSet = new MySqlCommand("SET character_set_client = utf8, character_set_connection = utf8, character_set_results = latin1;", conexion);
                    cmdSet.ExecuteNonQuery();

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@pass", contraseña);
                    cmd.Parameters.AddWithValue("@rol", rol);

                    int coincidencias = Convert.ToInt32(cmd.ExecuteScalar());

                    if (coincidencias > 0)
                    {
                        if (rol == "Administrador")
                        {
                            Administrador Admin = new Administrador(usuario);
                            Admin.Show();
                        }
                        else
                        {
                            Empleado Empl = new Empleado(usuario);
                            Empl.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario, contraseña o rol incorrectos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
		}
		void TxtContraseñaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtUsuarioTextChanged(object sender, EventArgs e)
		{
						
		}
		
		
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		
		}
		
		
		
		void TxtUsuarioClick(object sender, EventArgs e)
		{
			txtUsuario.Text = "";
			txtUsuario.ForeColor = Color.Black;
		}
		
		void TxtContraseñaClick(object sender, EventArgs e)
		{
			txtContraseña.Text = "";
			txtContraseña.ForeColor = Color.Black;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			pbInicio.BackColor = Color.Transparent;
   			pbInicio.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
