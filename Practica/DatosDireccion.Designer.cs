/*
 * Created by SharpDevelop.
 * User: a
 * Date: 09/10/2026
 * Time: 09:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class DatosDireccion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDireccion));
			this.pnlTrans = new System.Windows.Forms.Panel();
			this.listBoxTurno = new System.Windows.Forms.ListBox();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.lblTurno = new System.Windows.Forms.Label();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.lblCalle = new System.Windows.Forms.Label();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.lblColonia = new System.Windows.Forms.Label();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.lblCiudad = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblNecesidad = new System.Windows.Forms.Label();
			this.pnlTrans.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTrans
			// 
			this.pnlTrans.Controls.Add(this.listBoxTurno);
			this.pnlTrans.Controls.Add(this.btnSiguiente);
			this.pnlTrans.Controls.Add(this.lblTurno);
			this.pnlTrans.Controls.Add(this.txtCalle);
			this.pnlTrans.Controls.Add(this.lblCalle);
			this.pnlTrans.Controls.Add(this.txtColonia);
			this.pnlTrans.Controls.Add(this.lblColonia);
			this.pnlTrans.Controls.Add(this.txtCiudad);
			this.pnlTrans.Controls.Add(this.lblCiudad);
			this.pnlTrans.Controls.Add(this.pnlInfo);
			this.pnlTrans.Location = new System.Drawing.Point(198, 50);
			this.pnlTrans.Name = "pnlTrans";
			this.pnlTrans.Size = new System.Drawing.Size(413, 442);
			this.pnlTrans.TabIndex = 0;
			this.pnlTrans.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// listBoxTurno
			// 
			this.listBoxTurno.FormattingEnabled = true;
			this.listBoxTurno.ItemHeight = 16;
			this.listBoxTurno.Items.AddRange(new object[] {
									"M",
									"V",
									"N"});
			this.listBoxTurno.Location = new System.Drawing.Point(11, 305);
			this.listBoxTurno.Name = "listBoxTurno";
			this.listBoxTurno.Size = new System.Drawing.Size(120, 52);
			this.listBoxTurno.TabIndex = 10;
			this.listBoxTurno.SelectedIndexChanged += new System.EventHandler(this.ListBoxTurnoSelectedIndexChanged);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSiguiente.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Location = new System.Drawing.Point(11, 386);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(389, 38);
			this.btnSiguiente.TabIndex = 9;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguienteClick);
			// 
			// lblTurno
			// 
			this.lblTurno.BackColor = System.Drawing.Color.Transparent;
			this.lblTurno.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTurno.Location = new System.Drawing.Point(11, 272);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(400, 30);
			this.lblTurno.TabIndex = 7;
			this.lblTurno.Text = "Turno de trabajo.\r\nM(Matutino), V(Vespertino), N(nocturno)";
			// 
			// txtCalle
			// 
			this.txtCalle.Location = new System.Drawing.Point(11, 237);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(172, 22);
			this.txtCalle.TabIndex = 6;
			// 
			// lblCalle
			// 
			this.lblCalle.BackColor = System.Drawing.Color.Transparent;
			this.lblCalle.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCalle.Location = new System.Drawing.Point(11, 220);
			this.lblCalle.Name = "lblCalle";
			this.lblCalle.Size = new System.Drawing.Size(100, 23);
			this.lblCalle.TabIndex = 5;
			this.lblCalle.Text = "Calle:";
			// 
			// txtColonia
			// 
			this.txtColonia.Location = new System.Drawing.Point(11, 173);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(172, 22);
			this.txtColonia.TabIndex = 4;
			// 
			// lblColonia
			// 
			this.lblColonia.BackColor = System.Drawing.Color.Transparent;
			this.lblColonia.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColonia.ForeColor = System.Drawing.Color.White;
			this.lblColonia.Location = new System.Drawing.Point(11, 156);
			this.lblColonia.Name = "lblColonia";
			this.lblColonia.Size = new System.Drawing.Size(100, 23);
			this.lblColonia.TabIndex = 3;
			this.lblColonia.Text = "Colonia:";
			// 
			// txtCiudad
			// 
			this.txtCiudad.Location = new System.Drawing.Point(11, 113);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(172, 22);
			this.txtCiudad.TabIndex = 2;
			// 
			// lblCiudad
			// 
			this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
			this.lblCiudad.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCiudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCiudad.Location = new System.Drawing.Point(11, 96);
			this.lblCiudad.Name = "lblCiudad";
			this.lblCiudad.Size = new System.Drawing.Size(100, 23);
			this.lblCiudad.TabIndex = 1;
			this.lblCiudad.Text = "Ciudad:";
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.lblNecesidad);
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(413, 83);
			this.pnlInfo.TabIndex = 0;
			this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlInfoPaint);
			// 
			// lblNecesidad
			// 
			this.lblNecesidad.BackColor = System.Drawing.Color.Transparent;
			this.lblNecesidad.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNecesidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNecesidad.Location = new System.Drawing.Point(11, 15);
			this.lblNecesidad.Name = "lblNecesidad";
			this.lblNecesidad.Size = new System.Drawing.Size(300, 50);
			this.lblNecesidad.TabIndex = 0;
			this.lblNecesidad.Text = "Necesitamos conocer\r\ndatos de la direccion";
			// 
			// DatosDireccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(799, 593);
			this.Controls.Add(this.pnlTrans);
			this.Name = "DatosDireccion";
			this.Text = "DatosDireccion";
			this.pnlTrans.ResumeLayout(false);
			this.pnlTrans.PerformLayout();
			this.pnlInfo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listBoxTurno;
		private System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Label lblColonia;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.Label lblCalle;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.Label lblNecesidad;
		private System.Windows.Forms.Label lblCiudad;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Panel pnlTrans;
		
		void Panel1Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		pnlTrans.BackColor = System.Drawing.Color.FromArgb(80, 230, 230, 250);					
		}
		
		void PnlInfoPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		pnlTrans.BackColor = System.Drawing.Color.FromArgb(80, 230, 230, 250);
		}
		
		
		void BtnSiguienteClick(object sender, System.EventArgs e)
		{
		DatosTarjeta Tarjeta= new DatosTarjeta();
			Tarjeta.Show();			
		}
		
		
		void ListBoxTurnoSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
