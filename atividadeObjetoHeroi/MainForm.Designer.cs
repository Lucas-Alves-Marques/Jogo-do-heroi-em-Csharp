/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 12/09/2024
 * Hora: 21:03
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace atividadeObjetoHeroi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer_power;
		private System.Windows.Forms.Label label1;
		
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer_power = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(67, 449);
			this.progressBar1.Maximum = 6;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(209, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Value = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(328, 442);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 509);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.MaximumSize = new System.Drawing.Size(1008, 565);
			this.MinimumSize = new System.Drawing.Size(1008, 565);
			this.Name = "MainForm";
			this.Text = "atividadeObjetoHeroi";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);

		}
	}
}
