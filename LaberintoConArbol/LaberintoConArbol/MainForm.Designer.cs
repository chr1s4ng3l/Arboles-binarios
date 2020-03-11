/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 28/10/2019
 * Hora: 04:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LaberintoConArbol
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
			this.buttonCM = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMatriz = new System.Windows.Forms.TextBox();
			this.buttonCargar = new System.Windows.Forms.Button();
			this.textBoxdDatos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCM
			// 
			this.buttonCM.AutoSize = true;
			this.buttonCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCM.Location = new System.Drawing.Point(213, 193);
			this.buttonCM.Name = "buttonCM";
			this.buttonCM.Size = new System.Drawing.Size(112, 34);
			this.buttonCM.TabIndex = 11;
			this.buttonCM.Text = "Buscar";
			this.buttonCM.UseVisualStyleBackColor = true;
			this.buttonCM.Click += new System.EventHandler(this.ButtonCMClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(213, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Mapa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Datos.txt";
			// 
			// textBoxMatriz
			// 
			this.textBoxMatriz.BackColor = System.Drawing.Color.White;
			this.textBoxMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMatriz.Location = new System.Drawing.Point(213, 44);
			this.textBoxMatriz.MaxLength = 110;
			this.textBoxMatriz.Multiline = true;
			this.textBoxMatriz.Name = "textBoxMatriz";
			this.textBoxMatriz.Size = new System.Drawing.Size(121, 129);
			this.textBoxMatriz.TabIndex = 8;
			// 
			// buttonCargar
			// 
			this.buttonCargar.AutoSize = true;
			this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCargar.Location = new System.Drawing.Point(50, 193);
			this.buttonCargar.Name = "buttonCargar";
			this.buttonCargar.Size = new System.Drawing.Size(112, 34);
			this.buttonCargar.TabIndex = 7;
			this.buttonCargar.Text = "Cargar Datos";
			this.buttonCargar.UseVisualStyleBackColor = true;
			this.buttonCargar.Click += new System.EventHandler(this.ButtonCargarClick);
			// 
			// textBoxdDatos
			// 
			this.textBoxdDatos.BackColor = System.Drawing.Color.White;
			this.textBoxdDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxdDatos.Location = new System.Drawing.Point(50, 44);
			this.textBoxdDatos.MaxLength = 110;
			this.textBoxdDatos.Multiline = true;
			this.textBoxdDatos.Name = "textBoxdDatos";
			this.textBoxdDatos.ReadOnly = true;
			this.textBoxdDatos.Size = new System.Drawing.Size(128, 129);
			this.textBoxdDatos.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(378, 257);
			this.Controls.Add(this.buttonCM);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxMatriz);
			this.Controls.Add(this.buttonCargar);
			this.Controls.Add(this.textBoxdDatos);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LaberintoConArbol";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxdDatos;
		private System.Windows.Forms.Button buttonCargar;
		private System.Windows.Forms.TextBox textBoxMatriz;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCM;
	}
}
