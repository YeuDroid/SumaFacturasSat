/*
 * Created by SharpDevelop.
 * User: Yeu
 * Date: 13/03/2017
 * Time: 13:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SumaFacturas_Sat
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bCopiar;
		private System.Windows.Forms.Button bGetTotales;
		private System.Windows.Forms.Label lValores;
		private System.Windows.Forms.Label lTotales;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lvValores;
		private System.Windows.Forms.ImageList imageList;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bCopiar = new System.Windows.Forms.Button();
			this.bGetTotales = new System.Windows.Forms.Button();
			this.lValores = new System.Windows.Forms.Label();
			this.lTotales = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lvValores = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.79311F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.2069F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 348);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bCopiar);
			this.panel1.Controls.Add(this.bGetTotales);
			this.panel1.Controls.Add(this.lValores);
			this.panel1.Controls.Add(this.lTotales);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 311);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(626, 34);
			this.panel1.TabIndex = 1;
			// 
			// bCopiar
			// 
			this.bCopiar.Dock = System.Windows.Forms.DockStyle.Right;
			this.bCopiar.Location = new System.Drawing.Point(476, 0);
			this.bCopiar.Name = "bCopiar";
			this.bCopiar.Size = new System.Drawing.Size(75, 34);
			this.bCopiar.TabIndex = 3;
			this.bCopiar.Text = "Send CP";
			this.bCopiar.UseVisualStyleBackColor = true;
			// 
			// bGetTotales
			// 
			this.bGetTotales.Dock = System.Windows.Forms.DockStyle.Right;
			this.bGetTotales.Location = new System.Drawing.Point(551, 0);
			this.bGetTotales.Name = "bGetTotales";
			this.bGetTotales.Size = new System.Drawing.Size(75, 34);
			this.bGetTotales.TabIndex = 2;
			this.bGetTotales.Text = "Get Totales";
			this.bGetTotales.UseVisualStyleBackColor = true;
			this.bGetTotales.Click += new System.EventHandler(this.BGetTotalesClick);
			// 
			// lValores
			// 
			this.lValores.Dock = System.Windows.Forms.DockStyle.Left;
			this.lValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lValores.ForeColor = System.Drawing.Color.White;
			this.lValores.Location = new System.Drawing.Point(132, 0);
			this.lValores.Name = "lValores";
			this.lValores.Size = new System.Drawing.Size(132, 34);
			this.lValores.TabIndex = 1;
			this.lValores.Text = "V: 0";
			// 
			// lTotales
			// 
			this.lTotales.Dock = System.Windows.Forms.DockStyle.Left;
			this.lTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTotales.ForeColor = System.Drawing.Color.White;
			this.lTotales.Location = new System.Drawing.Point(0, 0);
			this.lTotales.Name = "lTotales";
			this.lTotales.Size = new System.Drawing.Size(132, 34);
			this.lTotales.TabIndex = 0;
			this.lTotales.Text = "$ 00.00";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvValores);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(626, 302);
			this.panel2.TabIndex = 2;
			// 
			// lvValores
			// 
			this.lvValores.Dock = System.Windows.Forms.DockStyle.Right;
			this.lvValores.LargeImageList = this.imageList;
			this.lvValores.Location = new System.Drawing.Point(440, 0);
			this.lvValores.Name = "lvValores";
			this.lvValores.Size = new System.Drawing.Size(186, 302);
			this.lvValores.SmallImageList = this.imageList;
			this.lvValores.TabIndex = 2;
			this.lvValores.UseCompatibleStateImageBehavior = false;
			this.lvValores.View = System.Windows.Forms.View.Tile;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Yen coin.ico");
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(431, 302);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextAlignChanged += new System.EventHandler(this.TextBox1TextAlignChanged);
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 348);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "SumaFacturas Sat";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
	}
}
