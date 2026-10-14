/*
 * Created by SharpDevelop.
 * User: a
 * Date: 11/10/2026
 * Time: 08:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class DatosRol
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosRol));
			this.pnlTransparente = new System.Windows.Forms.Panel();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.listBoxRol = new System.Windows.Forms.ListBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.lblSueldo = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblNecesidad = new System.Windows.Forms.Label();
			this.pnlTransparente.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTransparente
			// 
			this.pnlTransparente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlTransparente.Controls.Add(this.btnRegistrar);
			this.pnlTransparente.Controls.Add(this.listBoxRol);
			this.pnlTransparente.Controls.Add(this.lblRol);
			this.pnlTransparente.Controls.Add(this.txtSueldo);
			this.pnlTransparente.Controls.Add(this.lblSueldo);
			this.pnlTransparente.Controls.Add(this.pnlInfo);
			this.pnlTransparente.Location = new System.Drawing.Point(95, 31);
			this.pnlTransparente.Name = "pnlTransparente";
			this.pnlTransparente.Size = new System.Drawing.Size(326, 322);
			this.pnlTransparente.TabIndex = 0;
			this.pnlTransparente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTransparentePaint);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegistrar.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(13, 252);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(299, 41);
			this.btnRegistrar.TabIndex = 5;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// listBoxRol
			// 
			this.listBoxRol.FormattingEnabled = true;
			this.listBoxRol.ItemHeight = 16;
			this.listBoxRol.Items.AddRange(new object[] {
									"administrador",
									"empleado"});
			this.listBoxRol.Location = new System.Drawing.Point(13, 175);
			this.listBoxRol.Name = "listBoxRol";
			this.listBoxRol.Size = new System.Drawing.Size(120, 36);
			this.listBoxRol.TabIndex = 4;
			// 
			// lblRol
			// 
			this.lblRol.BackColor = System.Drawing.Color.Transparent;
			this.lblRol.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblRol.Location = new System.Drawing.Point(13, 149);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(100, 23);
			this.lblRol.TabIndex = 3;
			this.lblRol.Text = "Rol:";
			// 
			// txtSueldo
			// 
			this.txtSueldo.BackColor = System.Drawing.SystemColors.Window;
			this.txtSueldo.Location = new System.Drawing.Point(13, 94);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(100, 22);
			this.txtSueldo.TabIndex = 2;
			// 
			// lblSueldo
			// 
			this.lblSueldo.BackColor = System.Drawing.Color.Transparent;
			this.lblSueldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSueldo.Location = new System.Drawing.Point(13, 68);
			this.lblSueldo.Name = "lblSueldo";
			this.lblSueldo.Size = new System.Drawing.Size(100, 23);
			this.lblSueldo.TabIndex = 1;
			this.lblSueldo.Text = "Sueldo:";
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.lblNecesidad);
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(326, 52);
			this.pnlInfo.TabIndex = 0;
			this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlInfoPaint);
			// 
			// lblNecesidad
			// 
			this.lblNecesidad.BackColor = System.Drawing.Color.Transparent;
			this.lblNecesidad.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNecesidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNecesidad.Location = new System.Drawing.Point(13, 12);
			this.lblNecesidad.Name = "lblNecesidad";
			this.lblNecesidad.Size = new System.Drawing.Size(150, 23);
			this.lblNecesidad.TabIndex = 0;
			this.lblNecesidad.Text = "Ultimos datos!";
			// 
			// DatosRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(521, 431);
			this.Controls.Add(this.pnlTransparente);
			this.Name = "DatosRol";
			this.Text = "DatosRol";
			this.pnlTransparente.ResumeLayout(false);
			this.pnlTransparente.PerformLayout();
			this.pnlInfo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listBoxRol;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Label lblSueldo;
		private System.Windows.Forms.TextBox txtSueldo;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.Label lblNecesidad;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Panel pnlTransparente;
	}
}
