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
			timerMovimento.Interval = 150;
			timerMovimento.Tick += Movimento;			
			
		}
		
		int direcaoVertical = 1;
		
		public Timer timerMovimento = new Timer();
		
		void Movimento(object sender, EventArgs e)
		{
			Top += speed * direcaoVertical;
			
			if(Top >= 180) {
				direcaoVertical = -1;
			}
			
			if (Top <= -40) 
			{
				direcaoVertical = 1;
			}
		}
		
		public void PerdeVidasInimigo(){
		
		 if (MainForm.Vida_I1_12.Image != null) {
		 	
				MainForm.Vida_I1_12.Image = null;
				hp--;
				
		 }
			
		 else if (MainForm.Vida_I1_8.Image != null) {
		 	
				MainForm.Vida_I1_8.Image = null;
				hp--;	
		 }
		
		}

		
		public void FimdeJogo(){
			
			this.Dispose();
		}
		
		
	}
}
