using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Height = 100;
			Width = 120;
			Top = 0;
			Left = 550;
			Load("dragonEsq2.GIF");
			direcao = -1;
			timerMovimento.Enabled = true;
			timerMovimento.Interval = 100;
			timerMovimento.Tick += Movimento;	
			
		}
		
		int direcaoVertical = 1;
		
		public Timer timerMovimento = new Timer();
		public Timer timerExplosão = new Timer();

		
		void Movimento(object sender, EventArgs e)
		{
			Top += speed * direcaoVertical;
			
			if(Top >= 180)
			{
				direcaoVertical = -1;
			}
			
			if (Top <= -40) 
			{
				direcaoVertical = 1;
			}
		}
		
		void explosão(object sender, EventArgs e){
		
			timerExplosão.Stop();
			this.Dispose();
			Left = 5000;
		}
		
		public void Destruir()
		{
			timerMovimento.Enabled = false;
			Load("explosão2.gif");
			timerExplosão.Enabled = true;
			timerExplosão.Interval = 1500;
			timerExplosão.Tick += explosão;
				
		}
		
		
	}
}
