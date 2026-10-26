/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 26/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double n1, n2, resultado;

			n1 = Convert.ToDouble(txtNumero1.Text);
			n2 = Convert.ToDouble(txtNumero2.Text);
			
			resultado = n1 + n2;
			
			txtResultado.Text = resultado.ToString();
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double n1, n2, resultado;

			n1 = Convert.ToDouble(txtNumero1.Text);
			n2 = Convert.ToDouble(txtNumero2.Text);
			
			resultado = n1 - n2;
			
			txtResultado.Text = resultado.ToString();
		}
		
		void BtnMultClick(object sender, EventArgs e)
		{
			double n1, n2, resultado;

			n1 = Convert.ToDouble(txtNumero1.Text);
			n2 = Convert.ToDouble(txtNumero2.Text);
			
			resultado = n1 * n2;
			
			txtResultado.Text = resultado.ToString();
		}
		
		void BtnDivisionClick(object sender, EventArgs e)
		{
			double n1, n2, resultado;

			n1 = Convert.ToDouble(txtNumero1.Text);
			n2 = Convert.ToDouble(txtNumero2.Text);
			
			if (n2 != 0)
			{
			    resultado = n1 / n2;
			    txtResultado.Text = resultado.ToString();
			}
			else
			{
			    txtResultado.Text = "No se puede dividir entre cero";
			}
		}
		// Version 2: Modulo
		void BtnModuloClick(object sender, EventArgs e)
		{
			double n1, n2, resultado;

			n1 = Convert.ToDouble(txtNumero1.Text);
			n2 = Convert.ToDouble(txtNumero2.Text);
			
			if (n2 != 0)
			{
			    resultado = n1 % n2;
			    txtResultado.Text = resultado.ToString();
			}
			else
			{
			    txtResultado.Text = "No se puede dividir entre cero";
			}
		}
	}
}
