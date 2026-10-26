/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 26/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calculadora
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMult = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.btnFormula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculadora";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 1:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Numero 2:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Resultado:";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(165, 111);
			this.txtNumero1.Multiline = true;
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(206, 28);
			this.txtNumero1.TabIndex = 4;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(165, 153);
			this.txtNumero2.Multiline = true;
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(206, 28);
			this.txtNumero2.TabIndex = 5;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(165, 193);
			this.txtResultado.Multiline = true;
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(206, 28);
			this.txtResultado.TabIndex = 6;
			// 
			// btnSuma
			// 
			this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.Location = new System.Drawing.Point(25, 241);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(91, 78);
			this.btnSuma.TabIndex = 7;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.Location = new System.Drawing.Point(135, 241);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(91, 78);
			this.btnResta.TabIndex = 8;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMult
			// 
			this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMult.Location = new System.Drawing.Point(246, 241);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(91, 78);
			this.btnMult.TabIndex = 9;
			this.btnMult.Text = "*";
			this.btnMult.UseVisualStyleBackColor = true;
			this.btnMult.Click += new System.EventHandler(this.BtnMultClick);
			// 
			// btnDivision
			// 
			this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivision.Location = new System.Drawing.Point(354, 241);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(91, 78);
			this.btnDivision.TabIndex = 10;
			this.btnDivision.Text = "/";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.BtnDivisionClick);
			// 
			// btnModulo
			// 
			this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModulo.Location = new System.Drawing.Point(464, 241);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(91, 78);
			this.btnModulo.TabIndex = 11;
			this.btnModulo.Text = "%";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// btnFormula
			// 
			this.btnFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormula.Location = new System.Drawing.Point(25, 338);
			this.btnFormula.Name = "btnFormula";
			this.btnFormula.Size = new System.Drawing.Size(312, 56);
			this.btnFormula.TabIndex = 12;
			this.btnFormula.Text = "Formula general";
			this.btnFormula.UseVisualStyleBackColor = true;
			this.btnFormula.Click += new System.EventHandler(this.BtnFormulaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(577, 418);
			this.Controls.Add(this.btnFormula);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnMult);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnFormula;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Button btnMult;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
