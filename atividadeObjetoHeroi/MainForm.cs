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

		heroi julio = new heroi();
		Inimigo inimigo = new Inimigo();
		
		public static Timer timerTiro = new Timer();
		public static PictureBox Fundo = new PictureBox();
		public static ListBox listaTiros = new ListBox();
		public static ProgressBar barra = new ProgressBar();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//FUNDO
			
			Fundo.Parent = this;
			Fundo.Height = this.Height-120;
			Fundo.Width = this.Width;
			Fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			Fundo.Load("cenario0.gif");
			
			//BARRA DE PROGRESSO
			
			barra.Parent = this;
			barra.Left = 200;
			barra.Top = this.Height - 90;
			barra.Width = 200;
			barra.Maximum = 6;
			barra.Minimum = 0;
			barra.Step = 1;
			barra.Value = 6;
			
			//Tiro inimigo
			
			timerTiro.Tick += Tiro;
			timerTiro.Enabled = true;
			timerTiro.Interval = 1000;
			
			//
			
			julio.inimigo = inimigo;
			
		}
		
		public void Tiro(object sender, EventArgs e){
			
			tiroInimigo tiro = new tiroInimigo();
			tiro.Left = Left;
			tiro.Top = inimigo.Top + 50;
			tiro.Left = inimigo.Left -20;
			tiro.personagemAlvo = julio;
			tiro.Load("forceball.gif");
			
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
			
			if (e.KeyCode == Keys.Space) 
			{
				
				if (barra.Value > 0) 
				{
					tiro tiro = new tiro();
					listaTiros.Items.Add(tiro);
					tiro.Load("fireball.gif");
					tiro.Top = (int) julio.Top + (julio.Height/2) - tiro.Height;
					tiro.Left = julio.Left;
					tiro.personagemAlvo = inimigo;
					barra.Value -= 1;
					
					          
				}
				
			}
			
		}

	}
}