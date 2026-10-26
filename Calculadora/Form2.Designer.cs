/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 26/10/2026
 * Hora: 02:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calculadora
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(473, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "Formula general";
			// 
			// labelA
			// 
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.Location = new System.Drawing.Point(13, 101);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(174, 36);
			this.labelA.TabIndex = 1;
			this.labelA.Text = "Valor de A:";
			// 
			// labelB
			// 
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelB.Location = new System.Drawing.Point(13, 156);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(174, 36);
			this.labelB.TabIndex = 2;
			this.labelB.Text = "Valor de B:";
			// 
			// labelC
			// 
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelC.Location = new System.Drawing.Point(12, 209);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(174, 36);
			this.labelC.TabIndex = 3;
			this.labelC.Text = "Valor de C:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(13, 286);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(103, 85);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblX1
			// 
			this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX1.Location = new System.Drawing.Point(166, 286);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(174, 36);
			this.lblX1.TabIndex = 5;
			this.lblX1.Text = "X1: ";
			// 
			// lblX2
			// 
			this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX2.Location = new System.Drawing.Point(166, 335);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(174, 36);
			this.lblX2.TabIndex = 6;
			this.lblX2.Text = "X2:";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(182, 100);
			this.txtA.Multiline = true;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(187, 36);
			this.txtA.TabIndex = 7;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(182, 156);
			this.txtB.Multiline = true;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(187, 36);
			this.txtB.TabIndex = 8;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(182, 209);
			this.txtC.Multiline = true;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(187, 36);
			this.txtC.TabIndex = 9;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(498, 465);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.labelC);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelA);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label label1;
	}
}
