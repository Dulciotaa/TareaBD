/*
 * Created by SharpDevelop.
 * User: a
 * Date: 11/10/2026
 * Time: 07:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class DatosTarjeta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosTarjeta));
			this.pnlTransparente = new System.Windows.Forms.Panel();
			this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
			this.lblClaveSeguidad = new System.Windows.Forms.Label();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.txtCCV = new System.Windows.Forms.TextBox();
			this.lblCvv = new System.Windows.Forms.Label();
			this.txtnumeroTarjeta = new System.Windows.Forms.TextBox();
			this.lblNumeroTarjeta = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblNecesidad = new System.Windows.Forms.Label();
			this.pnlTransparente.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTransparente
			// 
			this.pnlTransparente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlTransparente.Controls.Add(this.txtClaveSeguridad);
			this.pnlTransparente.Controls.Add(this.lblClaveSeguidad);
			this.pnlTransparente.Controls.Add(this.btnSiguiente);
			this.pnlTransparente.Controls.Add(this.txtCCV);
			this.pnlTransparente.Controls.Add(this.lblCvv);
			this.pnlTransparente.Controls.Add(this.txtnumeroTarjeta);
			this.pnlTransparente.Controls.Add(this.lblNumeroTarjeta);
			this.pnlTransparente.Controls.Add(this.pnlInfo);
			this.pnlTransparente.Location = new System.Drawing.Point(198, 50);
			this.pnlTransparente.Name = "pnlTransparente";
			this.pnlTransparente.Size = new System.Drawing.Size(413, 304);
			this.pnlTransparente.TabIndex = 0;
			this.pnlTransparente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTransparentePaint);
			// 
			// txtClaveSeguridad
			// 
			this.txtClaveSeguridad.Location = new System.Drawing.Point(184, 188);
			this.txtClaveSeguridad.Name = "txtClaveSeguridad";
			this.txtClaveSeguridad.Size = new System.Drawing.Size(180, 22);
			this.txtClaveSeguridad.TabIndex = 7;
			// 
			// lblClaveSeguidad
			// 
			this.lblClaveSeguidad.BackColor = System.Drawing.Color.Transparent;
			this.lblClaveSeguidad.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClaveSeguidad.ForeColor = System.Drawing.Color.Snow;
			this.lblClaveSeguidad.Location = new System.Drawing.Point(184, 162);
			this.lblClaveSeguidad.Name = "lblClaveSeguidad";
			this.lblClaveSeguidad.Size = new System.Drawing.Size(180, 23);
			this.lblClaveSeguidad.TabIndex = 6;
			this.lblClaveSeguidad.Text = "Clave de seguridad";
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSiguiente.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Location = new System.Drawing.Point(14, 246);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(376, 40);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguienteClick);
			// 
			// txtCCV
			// 
			this.txtCCV.Location = new System.Drawing.Point(14, 188);
			this.txtCCV.Name = "txtCCV";
			this.txtCCV.Size = new System.Drawing.Size(87, 22);
			this.txtCCV.TabIndex = 4;
			// 
			// lblCvv
			// 
			this.lblCvv.BackColor = System.Drawing.Color.Transparent;
			this.lblCvv.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCvv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCvv.Location = new System.Drawing.Point(14, 162);
			this.lblCvv.Name = "lblCvv";
			this.lblCvv.Size = new System.Drawing.Size(100, 23);
			this.lblCvv.TabIndex = 3;
			this.lblCvv.Text = "CCV";
			// 
			// txtnumeroTarjeta
			// 
			this.txtnumeroTarjeta.Location = new System.Drawing.Point(14, 122);
			this.txtnumeroTarjeta.Name = "txtnumeroTarjeta";
			this.txtnumeroTarjeta.Size = new System.Drawing.Size(211, 22);
			this.txtnumeroTarjeta.TabIndex = 2;
			// 
			// lblNumeroTarjeta
			// 
			this.lblNumeroTarjeta.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroTarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNumeroTarjeta.Location = new System.Drawing.Point(14, 96);
			this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
			this.lblNumeroTarjeta.Size = new System.Drawing.Size(150, 23);
			this.lblNumeroTarjeta.TabIndex = 1;
			this.lblNumeroTarjeta.Text = "Numero de tarjeta";
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.lblNecesidad);
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(413, 80);
			this.pnlInfo.TabIndex = 0;
			this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlInfoPaint);
			// 
			// lblNecesidad
			// 
			this.lblNecesidad.BackColor = System.Drawing.Color.Transparent;
			this.lblNecesidad.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNecesidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNecesidad.Location = new System.Drawing.Point(14, 17);
			this.lblNecesidad.Name = "lblNecesidad";
			this.lblNecesidad.Size = new System.Drawing.Size(350, 50);
			this.lblNecesidad.TabIndex = 0;
			this.lblNecesidad.Text = "Necesitamos conocer\r\nalgunos datos de la tarjeta de credito";
			// 
			// DatosTarjeta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(761, 461);
			this.Controls.Add(this.pnlTransparente);
			this.Name = "DatosTarjeta";
			this.Text = "DatosTarjeta";
			this.pnlTransparente.ResumeLayout(false);
			this.pnlTransparente.PerformLayout();
			this.pnlInfo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblClaveSeguidad;
		private System.Windows.Forms.TextBox txtClaveSeguridad;
		private System.Windows.Forms.TextBox txtnumeroTarjeta;
		private System.Windows.Forms.Label lblCvv;
		private System.Windows.Forms.TextBox txtCCV;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Label lblNumeroTarjeta;
		private System.Windows.Forms.Label lblNecesidad;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Panel pnlTransparente;
	}
}
