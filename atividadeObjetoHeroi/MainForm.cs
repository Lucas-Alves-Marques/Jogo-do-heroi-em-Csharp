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

		public heroi julio = new heroi();
		public Inimigo inimigo = new Inimigo();
		

		public static Timer timerTiro = new Timer();
		public static ListBox listaTiros = new ListBox();
		public static ProgressBar barra = new ProgressBar();
		
		public static PictureBox Fundo = new PictureBox();
		
		public static Vida Vida_H_1 = new Vida();
		public static Vida Vida_H_2 = new Vida();
		public static Vida Vida_H_3 = new Vida();
		public static Vida Vida_H_4 = new Vida();
		public static Vida Vida_H_5 = new Vida();
		
		public static defesa escudo1 = new defesa();
		public static defesa escudo2 = new defesa();
		public static defesa escudo3 = new defesa();
		public static defesa escudo4 = new defesa();
		public static defesa escudo5 = new defesa();
		
		public static Vida Vida_I1_1 = new Vida();
		public static Vida Vida_I1_2 = new Vida();
		public static Vida Vida_I1_3 = new Vida();
		public static Vida Vida_I1_4 = new Vida();
		public static Vida Vida_I1_5 = new Vida();
		public static Vida Vida_I1_6 = new Vida();
		public static Vida Vida_I1_7 = new Vida();
		public static Vida Vida_I1_8 = new Vida();
		public static Vida Vida_I1_9 = new Vida();
		public static Vida Vida_I1_10 = new Vida();
		public static Vida Vida_I1_11 = new Vida();
		public static Vida Vida_I1_12 = new Vida();

		
		
		
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
			barra.Left = 10;
			barra.Top = this.Height - 70;
			barra.Width = 200;
			barra.Maximum = 6;
			barra.Minimum = 0;
			barra.Step = 1;
			barra.Value = 6;
			
			//Tiro inimigo
			
			julio.inimigo = inimigo;
			timerTiro.Tick += Tiro;
			timerTiro.Enabled = true;
			timerTiro.Interval = 1000;
			
			// Vida Inimigo
			
			Vida_I1_4.Parent = this;
			Vida_I1_4.Left = 620;
			Vida_I1_3.Parent = this;
			Vida_I1_3.Left = 595;
			Vida_I1_2.Parent = this;
			Vida_I1_2.Left = 570;
			Vida_I1_1.Parent = this;
			Vida_I1_1.Left = 545;
			
			Vida_I1_8.Parent = this;
			Vida_I1_8.Left = 620;
			Vida_I1_8.Top += 25;
			Vida_I1_7.Parent = this;
			Vida_I1_7.Left = 595;
			Vida_I1_7.Top += 25;
			Vida_I1_6.Parent = this;
			Vida_I1_6.Left = 570;
			Vida_I1_6.Top += 25;
			Vida_I1_5.Parent = this;
			Vida_I1_5.Left = 545;
			Vida_I1_5.Top += 25;
			
			Vida_I1_12.Parent = this;
			Vida_I1_12.Left = 620;
			Vida_I1_12.Top += 50;
			Vida_I1_12.Image = null;
			Vida_I1_11.Parent = this;
			Vida_I1_11.Left = 595;
			Vida_I1_11.Top += 50;
			Vida_I1_11.Image = null;
			Vida_I1_10.Parent = this;
			Vida_I1_10.Left = 570;
			Vida_I1_10.Top += 50;
			Vida_I1_10.Image = null;
			Vida_I1_9.Parent = this;
			Vida_I1_9.Left = 545;
			Vida_I1_9.Top += 50;
			Vida_I1_9.Image = null;
			
			inimigo.hp = 8;
			
			
			
			
			//Vida do Heroi
			
			Vida_H_1.Parent = this;
			Vida_H_2.Parent = this;
			Vida_H_2.Left = 35;
			Vida_H_3.Parent = this;
			Vida_H_3.Left = 60;
			Vida_H_4.Parent = this;
			Vida_H_4.Left = 85;
			Vida_H_5.Parent = this;
			Vida_H_5.Left = 110;
			
			//Defesa do Heroi
			
			escudo1.Parent = this;
			escudo2.Parent = this;
			escudo2.Left = 35;
			escudo3.Parent = this;
			escudo3.Left = 57;
			escudo4.Parent = this;
			escudo4.Left = 79;
			escudo4.Image = null;
			escudo5.Parent = this;
			escudo5.Left = 101;
			escudo5.Image = null;
			
						
		}
		
		public void Tiro(object sender, EventArgs e){
			
			tiroInimigo tiro = new tiroInimigo();
			tiro.Top = inimigo.Top + 50;
			tiro.Left = inimigo.Left -20;
			tiro.personagemAlvo = julio;
			tiro.Load("fireball2.gif");
			
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
					julio.direcao = 1;
					julio.Load("Gargoyle.gif");
					
					          
				}
				
			}
			
		}

	}
}