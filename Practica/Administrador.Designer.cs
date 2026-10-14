/*
 * Created by SharpDevelop.
 * User: dulma
 * Date: 09/10/2026
 * Time: 09:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class Administrador
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
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dtGVTablaUsers = new System.Windows.Forms.DataGridView();
			this.lblMostUsuario = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pnlPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGVTablaUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlPrincipal.Controls.Add(this.label1);
			this.pnlPrincipal.Controls.Add(this.dtGVTablaUsers);
			this.pnlPrincipal.Location = new System.Drawing.Point(12, 28);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(775, 550);
			this.pnlPrincipal.TabIndex = 0;
			this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPrincipalPaint);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(432, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lista de usuarios:";
			// 
			// dtGVTablaUsers
			// 
			this.dtGVTablaUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtGVTablaUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGVTablaUsers.Location = new System.Drawing.Point(3, 57);
			this.dtGVTablaUsers.Name = "dtGVTablaUsers";
			this.dtGVTablaUsers.RowTemplate.Height = 24;
			this.dtGVTablaUsers.Size = new System.Drawing.Size(703, 481);
			this.dtGVTablaUsers.TabIndex = 1;
			// 
			// lblMostUsuario
			// 
			this.lblMostUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMostUsuario.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMostUsuario.Location = new System.Drawing.Point(15, 0);
			this.lblMostUsuario.Name = "lblMostUsuario";
			this.lblMostUsuario.Size = new System.Drawing.Size(583, 38);
			this.lblMostUsuario.TabIndex = 0;
			this.lblMostUsuario.Text = "Bienvenido, administrador";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
			this.btnEliminar.Location = new System.Drawing.Point(703, 590);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 28);
			this.btnEliminar.TabIndex = 1;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.Location = new System.Drawing.Point(451, 590);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 28);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnEditar.Location = new System.Drawing.Point(571, 590);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 28);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSalir.Location = new System.Drawing.Point(70, 590);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 26);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Administrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(799, 630);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.lblMostUsuario);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.pnlPrincipal);
			this.Name = "Administrador";
			this.Text = "Administrador";
			this.Load += new System.EventHandler(this.AdministradorLoad);
			this.pnlPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGVTablaUsers)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridView dtGVTablaUsers;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblMostUsuario;
		private System.Windows.Forms.Panel pnlPrincipal;
	}
}
