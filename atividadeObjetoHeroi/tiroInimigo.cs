using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class tiroInimigo : PictureBox
	{
		public tiroInimigo()
		{
			Width = 30;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.Fundo;
			timerMovi.Enabled = true;
			timerMovi.Tick += Movimento;
			Load("forceball.gif");
		}
		
		Timer timerMovi = new Timer();
		public int direcao = 1;
		public int speed = 30;
		public int dano = 10;
		public Personagem personagemAlvo;
		
		void Movimento(object sender, EventArgs e)
		{
			
			Left -= direcao * speed;
			
			
			if (Left < 0) {
				
				Destruir();
			}
			
			else if(personagemAlvo.Bounds.IntersectsWith(this.Bounds)){

					(personagemAlvo as heroi).PerdeVidas();
				
					Destruir();
				
				}
				
			if (heroi.cenario == 1) {
				
				Load("forceball.gif");
				speed = 40;
				MainForm.timerTiro.Interval = 2000;
				
			}
			
			if (heroi.cenario == 2) {
				
				Load("Caveira.gif");
				speed = 60;
				MainForm.timerTiro.Interval = 1400;
			}
			
		}
		
		public void Destruir()
		{
			timerMovi.Enabled = false;
			Left = 600;
			this.Dispose();
		}
	}
}
