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
			this.btnLogIn = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.DarkGray;
			this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnLogIn.FlatAppearance.BorderSize = 5;
			this.btnLogIn.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnLogIn.Location = new System.Drawing.Point(211, 336);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(113, 29);
			this.btnLogIn.TabIndex = 0;
			this.btnLogIn.Text = "Iniciar Sesión";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(137, 127);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(315, 22);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.Text = "Ingrese su usuario";
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuarioTextChanged);
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(137, 204);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(315, 22);
			this.txtContraseña.TabIndex = 2;
			this.txtContraseña.Text = "Ingrese contraseña";
			this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseñaTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(211, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 49);
			this.label1.TabIndex = 3;
			this.label1.Text = "LOGIN";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(113, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(369, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ingrese su usuario y su contraseña para iniciar sesión:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(574, 421);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnLogIn);
			this.Name = "MainForm";
			this.Text = "Practica";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnLogIn;
	}
}
