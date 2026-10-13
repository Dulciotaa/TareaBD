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

            string consulta = "SELECT usuario, nombre, apellido, correo, ciudad, calle, colonia, turno, CAST(AES_DECRYPT(numeroTarjeta, 'ivarodul') AS CHAR(16)) AS numeroTarjeta, CAST(AES_DECRYPT(ccv, 'ivarodul') AS CHAR(3)) as ccv, CAST(AES_DECRYPT(claveSeguridad, 'ivarodul') AS CHAR(5)) as clave, fechaCreacion, sueldo, rol FROM usuarios";

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
            if (dtGVTablaUsers.CurrentRow == null || dtGVTablaUsers.CurrentRow.IsNewRow)
            {
                MessageBox.Show("selecciona una fila valida para editar.");
                return;
            }

            DataGridViewRow fila = dtGVTablaUsers.CurrentRow;

            string usuario        = Convert.ToString(fila.Cells[0].Value);
            string nombre         = Convert.ToString(fila.Cells[1].Value);
            string apellido       = Convert.ToString(fila.Cells[2].Value);
            string correo         = Convert.ToString(fila.Cells[3].Value);
            string ciudad         = Convert.ToString(fila.Cells[4].Value);
            string calle          = Convert.ToString(fila.Cells[5].Value);
            string colonia        = Convert.ToString(fila.Cells[6].Value);
            string turno          = Convert.ToString(fila.Cells[7].Value);
            string numeroTarjeta  = Convert.ToString(fila.Cells[8].Value);
            string ccv            = Convert.ToString(fila.Cells[9].Value);
            string claveSeguridad = Convert.ToString(fila.Cells[10].Value);
            // fila.Cells[11] es fechaCreacion
            string sueldo         = Convert.ToString(fila.Cells[12].Value);
            string rol            = Convert.ToString(fila.Cells[13].Value);

            string cadenaConexion = "Server=practica.mysql.database.azure.com; Port=3306; Database=practicalogin; Uid=ivarodul; Pwd=13579135Ca; SslMode=None;";

            string consultaUpdate = @"UPDATE usuarios SET nombre = @nombre, apellido = @apellido, correo = @correo, ciudad = @ciudad, calle = @calle, colonia = @colonia, turno = @turno, numeroTarjeta = AES_ENCRYPT(@numeroTarjeta, 'ivarodul'), ccv = AES_ENCRYPT(@ccv, 'ivarodul'), claveSeguridad = AES_ENCRYPT(@claveSeguridad, 'ivarodul'), sueldo = @sueldo, rol = @rol WHERE usuario = @usuario";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consultaUpdate, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@ciudad", ciudad);
                        cmd.Parameters.AddWithValue("@calle", calle);
                        cmd.Parameters.AddWithValue("@colonia", colonia);
                        cmd.Parameters.AddWithValue("@turno", turno);
                        cmd.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                        cmd.Parameters.AddWithValue("@ccv", ccv);
                        cmd.Parameters.AddWithValue("@claveSeguridad", claveSeguridad);
                        cmd.Parameters.AddWithValue("@sueldo", sueldo);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario actualizado correctamente.");
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro el usuario para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
                }
            }
        }

        void BtnEliminarClick(object sender, EventArgs e)
        {
            if (dtGVTablaUsers.CurrentRow == null || dtGVTablaUsers.CurrentRow.IsNewRow)
            {
                MessageBox.Show("selecciona una fila valida");
                return;
            }

            DialogResult resu = MessageBox.Show("Ar yu chur???", "SEGUROOO??? ALERTAAAA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resu == DialogResult.Yes)
            {
                DataGridViewRow fila = dtGVTablaUsers.CurrentRow;
                string usuario = Convert.ToString(fila.Cells[0].Value);

                string cadenaConexion = "Server=practica.mysql.database.azure.com; Port=3306; Database=practicalogin; Uid=ivarodul; Pwd=13579135Ca; SslMode=None;";

                string consultaDelete = "DELETE FROM usuarios WHERE usuario = @usuario;";

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    try
                    {
                        conexion.Open();
                        using (MySqlCommand cmd = new MySqlCommand(consultaDelete, conexion))
                        {
                            cmd.Parameters.AddWithValue("@usuario", usuario);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario Eliminado");
                                CargarDatos();
                            }
                            else
                            {
                                MessageBox.Show("No se encontro el usuario");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar en la base de datos: " + ex.Message);
                    }
                }
            }
            else if (resu == DialogResult.No)
            {
                MessageBox.Show("Cancelado");
            }
        }

        void BtnSalirClick(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        void AdministradorLoad(object sender, EventArgs e)
        {
            CargarDatos();
            pnlPrincipal.BackColor = Color.FromArgb(100, 250, 250, 250);
        }
    }
}