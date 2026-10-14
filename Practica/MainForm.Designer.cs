/*
 * Created by SharpDevelop.
 * User: a
 * Date: 07/10/2026
 * Time: 10:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnLogIn = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.pbInicio = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogIn
			// 
			this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogIn.BackColor = System.Drawing.Color.DarkGray;
			this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnLogIn.FlatAppearance.BorderSize = 5;
			this.btnLogIn.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnLogIn.Location = new System.Drawing.Point(223, 329);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(113, 29);
			this.btnLogIn.TabIndex = 0;
			this.btnLogIn.Text = "Iniciar Sesión";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtUsuario.Location = new System.Drawing.Point(137, 177);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(268, 22);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.Text = "Ingrese su usuario";
			this.txtUsuario.Click += new System.EventHandler(this.TxtUsuarioClick);
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuarioTextChanged);
			// 
			// txtContraseña
			// 
			this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtContraseña.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.txtContraseña.Location = new System.Drawing.Point(137, 227);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(268, 22);
			this.txtContraseña.TabIndex = 2;
			this.txtContraseña.Text = "Ingrese contraseña";
			this.txtContraseña.Click += new System.EventHandler(this.TxtContraseñaClick);
			this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseñaTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(114, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(369, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ingrese su usuario y su contraseña para iniciar sesión:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCerrar.BackColor = System.Drawing.Color.DarkGray;
			this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnCerrar.FlatAppearance.BorderSize = 5;
			this.btnCerrar.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnCerrar.Location = new System.Drawing.Point(12, 380);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(113, 29);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// cmbRol
			// 
			this.cmbRol.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
									"Administrador",
									"Empleado"});
			this.cmbRol.Location = new System.Drawing.Point(223, 287);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(121, 24);
			this.cmbRol.TabIndex = 7;
			this.cmbRol.Text = "Administrador";
			// 
			// lblLogin
			// 
			this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLogin.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.lblLogin.Location = new System.Drawing.Point(223, 19);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(136, 41);
			this.lblLogin.TabIndex = 8;
			this.lblLogin.Text = "LOGIN";
			// 
			// pbInicio
			// 
			this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
			this.pbInicio.Location = new System.Drawing.Point(236, 86);
			this.pbInicio.Name = "pbInicio";
			this.pbInicio.Size = new System.Drawing.Size(90, 85);
			this.pbInicio.TabIndex = 9;
			this.pbInicio.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(574, 421);
			this.Controls.Add(this.pbInicio);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnLogIn);
			this.Name = "MainForm";
			this.Text = "Practica";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbInicio;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnLogIn;
	}
}
