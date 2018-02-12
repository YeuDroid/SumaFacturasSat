/*
 * Created by SharpDevelop.
 * User: Yeu
 * Date: 13/03/2017
 * Time: 13:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SumaFacturas_Sat
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		System.Collections.ArrayList Valores;
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
		void sacarValores(string cadena)
		{
			this.Valores = new System.Collections.ArrayList();
			bool cortar=false;
			string tempVal="";
			foreach(char v in cadena)
			{
				if(v.ToString() == "$")
				{
					cortar =true;
					continue;
				}
				if((String.IsNullOrWhiteSpace(v.ToString())) && (cortar == true))
				{
					cortar=false;
					tempVal = tempVal.Replace(",",".");
					tempVal = tempVal.Replace(".",",");
					Valores.Add(tempVal.Trim());
					tempVal="";
					continue;
				}
				if(cortar)
				{
					tempVal += v;
				}
			}
		}
		void sendToClipboard()
		{ 
			
		}
		void fillArbol()
		{
			lvValores.Items.Clear();
			foreach(string val in this.Valores)
			{
			   this.lvValores.Items.Add(val,0);
			}
		}
		void printNumValues()
		{
			decimal total = decimal.Zero;
		
			foreach(string value in this.Valores)
			{
				total= total + Convert.ToDecimal(value.Replace(".",","));
			}
			
			lTotales.Text= "$: " + total.ToString().Insert(total.ToString().Length -2,",");
			lValores.Text= "V: " + Valores.Count.ToString();
		}
		void BGetTotalesClick(object sender, EventArgs e)
		{
			sacarValores(this.textBox1.Text);
			printNumValues();
			fillArbol();
		}
		void TValoresAfterSelect(object sender, TreeViewEventArgs e)
		{
	
		}
		
		void TextBox1TextAlignChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			sacarValores(this.textBox1.Text);
			printNumValues();
			fillArbol();
		}
	}
}
