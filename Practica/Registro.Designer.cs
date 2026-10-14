/*
 * Created by SharpDevelop.
 * User: a
 * Date: 08/10/2026
 * Time: 07:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class Registro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.lblApellidos = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblInfo2 = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.lblContraseña);
			this.panel1.Controls.Add(this.txtContraseña);
			this.panel1.Controls.Add(this.lblCorreo);
			this.panel1.Controls.Add(this.lblApellidos);
			this.panel1.Controls.Add(this.lblNombre);
			this.panel1.Controls.Add(this.lblUsuario);
			this.panel1.Controls.Add(this.btnSiguiente);
			this.panel1.Controls.Add(this.txtCorreo);
			this.panel1.Controls.Add(this.txtApellidos);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(198, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(413, 442);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// lblContraseña
			// 
			this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
			this.lblContraseña.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.ForeColor = System.Drawing.Color.White;
			this.lblContraseña.Location = new System.Drawing.Point(21, 328);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 15);
			this.lblContraseña.TabIndex = 11;
			this.lblContraseña.Text = "Contraseña";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(21, 343);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(233, 22);
			this.txtContraseña.TabIndex = 10;
			// 
			// lblCorreo
			// 
			this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
			this.lblCorreo.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.ForeColor = System.Drawing.Color.White;
			this.lblCorreo.Location = new System.Drawing.Point(18, 262);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(100, 15);
			this.lblCorreo.TabIndex = 9;
			this.lblCorreo.Text = "Correo";
			// 
			// lblApellidos
			// 
			this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
			this.lblApellidos.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellidos.ForeColor = System.Drawing.Color.White;
			this.lblApellidos.Location = new System.Drawing.Point(18, 202);
			this.lblApellidos.Name = "lblApellidos";
			this.lblApellidos.Size = new System.Drawing.Size(100, 15);
			this.lblApellidos.TabIndex = 8;
			this.lblApellidos.Text = "Last name";
			// 
			// lblNombre
			// 
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(18, 148);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 14);
			this.lblNombre.TabIndex = 7;
			this.lblNombre.Text = "Nombre(s)";
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblUsuario.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.White;
			this.lblUsuario.Location = new System.Drawing.Point(18, 92);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(100, 18);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Usuario";
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSiguiente.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Location = new System.Drawing.Point(18, 381);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(377, 43);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(18, 280);
			this.txtCorreo.Multiline = true;
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(377, 35);
			this.txtCorreo.TabIndex = 4;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(18, 220);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(236, 22);
			this.txtApellidos.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(18, 165);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(236, 22);
			this.txtNombre.TabIndex = 2;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(18, 109);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(236, 22);
			this.txtUsuario.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.lblInfo2);
			this.panel2.Controls.Add(this.lblInfo);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(412, 76);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// lblInfo2
			// 
			this.lblInfo2.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo2.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInfo2.Location = new System.Drawing.Point(17, 40);
			this.lblInfo2.Name = "lblInfo2";
			this.lblInfo2.Size = new System.Drawing.Size(300, 23);
			this.lblInfo2.TabIndex = 1;
			this.lblInfo2.Text = "Llene los datos de usuario";
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInfo.Location = new System.Drawing.Point(17, 10);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(250, 40);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "Datos de usuario";
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(797, 562);
			this.Controls.Add(this.panel1);
			this.Name = "Registro";
			this.Text = "Registro";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellidos;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label lblInfo2;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
