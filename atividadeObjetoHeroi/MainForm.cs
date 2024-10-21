using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public static PictureBox Fundo = new PictureBox();
		
		heroi julio = new heroi();
		
		tiro geral = new tiro();
		
		public static int n_tiros = 6;
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Fundo.Parent = this;
			Fundo.Height = this.Height-120;
			Fundo.Width = this.Width;
			Fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			Fundo.Load("cenario0.gif");
			timer_power.Enabled = true;
			label1.Text= n_tiros.ToString();
			
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e){	
			
				
			if(e.KeyCode == Keys.A){
				
				julio.MovEsq();
			}
			
			if(e.KeyCode == Keys.D){
				
				julio.MovDir();
				
			}
			
			if(e.KeyCode == Keys.W){
				
				julio.MovCima();
			}
			
			if(e.KeyCode == Keys.S){
				
				julio.MovBaixo();
				
				
			}
			
			if (e.KeyCode == Keys.Space) {
				
				
				if (progressBar1.Value > 0) {
				
					julio.Tiro();
					
					n_tiros--;
				
					progressBar1.Value = n_tiros;
				
				}
		
			}
			
		}

	}
}