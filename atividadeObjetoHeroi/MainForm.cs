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
		
		public static Vida_Heroi Vida1 = new Vida_Heroi();
		public static Vida_Heroi Vida2 = new Vida_Heroi();
		public static Vida_Heroi Vida3 = new Vida_Heroi();
		public static Vida_Heroi Vida4 = new Vida_Heroi();
		public static Vida_Heroi Vida5 = new Vida_Heroi();
		
		public static defesa escudo1 = new defesa();
		public static defesa escudo2 = new defesa();
		public static defesa escudo3 = new defesa();
		public static defesa escudo4 = new defesa();
		public static defesa escudo5 = new defesa();
		
		
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
			
			//Vida do Heroi
			
			Vida1.Parent = this;
			Vida2.Parent = this;
			Vida2.Left = 35;
			Vida3.Parent = this;
			Vida3.Left = 60;
			Vida4.Parent = this;
			Vida4.Left = 85;
			Vida5.Parent = this;
			Vida5.Left = 110;
			
			//Defesa do Heroi
			
			escudo1.Parent = this;
			escudo2.Parent = this;
			escudo2.Left = 35;
			escudo3.Parent = this;
			escudo3.Left = 57;
			//escudo4.Parent = this;
			//escudo4.Left = 79;
			//escudo5.Parent = this;
			//escudo5.Left = 101;
			
						
		}
		
		public void Tiro(object sender, EventArgs e){
			
			tiroInimigo tiro = new tiroInimigo();
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
					julio.direcao = 1;
					julio.Load("Gargoyle.gif");
					
					          
				}
				
			}
			
		}

	}
}