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
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(198, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(413, 442);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(21, 328);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Contraseña";
		
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(21, 343);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(233, 22);
			this.textBox5.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(18, 262);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Correo";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(18, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Last name";
			
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(18, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "First name";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(18, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Usuario";
			
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(18, 381);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(377, 43);
			this.button1.TabIndex = 5;
			this.button1.Text = "Siguiente";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(18, 280);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(377, 35);
			this.textBox4.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(18, 220);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(236, 22);
			this.textBox3.TabIndex = 3;
			
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(18, 165);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(236, 22);
			this.textBox2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 109);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(236, 22);
			this.textBox1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(412, 76);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(17, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(300, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Llene los datos de usuario";
			
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(17, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datos de usuario";
			
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
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
