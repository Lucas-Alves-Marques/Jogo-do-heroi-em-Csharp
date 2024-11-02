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
			Width = 60;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.Fundo;
			timerMovi.Enabled = true;
			timerMovi.Tick += Movimento;
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
			
		}
		
		public void Destruir()
		{
			timerMovi.Enabled = false;
			Left = 600;
			this.Dispose();
		}
	}
}
