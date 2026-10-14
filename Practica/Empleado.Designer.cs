/*
 * Created by SharpDevelop.
 * User: dulma
 * Date: 09/10/2026
 * Time: 10:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class Empleado
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
			this.pnlCentral = new System.Windows.Forms.Panel();
			this.dtGVTablaUsers = new System.Windows.Forms.DataGridView();
			this.lblMostrUsuario = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pnlCentral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGVTablaUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCentral
			// 
			this.pnlCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCentral.Controls.Add(this.dtGVTablaUsers);
			this.pnlCentral.Controls.Add(this.lblMostrUsuario);
			this.pnlCentral.Location = new System.Drawing.Point(57, 58);
			this.pnlCentral.Name = "pnlCentral";
			this.pnlCentral.Size = new System.Drawing.Size(691, 543);
			this.pnlCentral.TabIndex = 0;
			this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCentralPaint);
			// 
			// dtGVTablaUsers
			// 
			this.dtGVTablaUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtGVTablaUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGVTablaUsers.Location = new System.Drawing.Point(0, 45);
			this.dtGVTablaUsers.Name = "dtGVTablaUsers";
			this.dtGVTablaUsers.RowTemplate.Height = 24;
			this.dtGVTablaUsers.Size = new System.Drawing.Size(691, 495);
			this.dtGVTablaUsers.TabIndex = 1;
			// 
			// lblMostrUsuario
			// 
			this.lblMostrUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMostrUsuario.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMostrUsuario.Location = new System.Drawing.Point(0, 0);
			this.lblMostrUsuario.Name = "lblMostrUsuario";
			this.lblMostrUsuario.Size = new System.Drawing.Size(347, 42);
			this.lblMostrUsuario.TabIndex = 2;
			this.lblMostrUsuario.Text = "Bienvenido";
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSalir.Location = new System.Drawing.Point(57, 622);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Empleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(816, 657);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.pnlCentral);
			this.Name = "Empleado";
			this.Text = "Empleado";
			this.Load += new System.EventHandler(this.EmpleadoLoad);
			this.pnlCentral.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGVTablaUsers)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridView dtGVTablaUsers;
		private System.Windows.Forms.Label lblMostrUsuario;
		private System.Windows.Forms.Panel pnlCentral;
	}
}
