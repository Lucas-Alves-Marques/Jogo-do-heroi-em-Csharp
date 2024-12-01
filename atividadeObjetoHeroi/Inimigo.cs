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
			Load("Boss1.GIF");
			direcao = -1;
			timerMovimento.Enabled = true;
			timerMovimento.Interval = 150;
			timerMovimento.Tick += Movimento;
			hp = 8;
			
		}
		
		int direcaoVertical = 1;
		
		public tiroInimigo rajada;
		
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
		
			if (hp == 12) {
				
				MainForm.Vida_I1_12.Image = null;
				hp--;
			}
			
			else if (hp == 11) {
				
				MainForm.Vida_I1_11.Image = null;
				hp--;
			}
			
			else if (hp == 10) {
				
				MainForm.Vida_I1_10.Image = null;
				hp--;
			}
			
			else if (hp == 9) {
				
				MainForm.Vida_I1_9.Image = null;
				hp--;
			}
			
			else if (hp == 8) {
				
				MainForm.Vida_I1_8.Image = null;
				hp--;
			}
			
			else if (hp == 7) {
				
				MainForm.Vida_I1_7.Image = null;
				hp--;
			}
			
			else if (hp == 6) {
				
				MainForm.Vida_I1_6.Image = null;
				hp--;
			}
			
			else if (hp == 5) {
				
				MainForm.Vida_I1_5.Image = null;
				hp--;
			}
			
			else if (hp == 4) {
				
				MainForm.Vida_I1_4.Image = null;
				hp--;
			}
			
			else if (hp == 3) {
				
				MainForm.Vida_I1_3.Image = null;
				hp--;
			}
			
			else if (hp == 2) {
				
				MainForm.Vida_I1_2.Image = null;
				hp--;
			}
			
			else if (hp == 1) {
				
				MainForm.Vida_I1_1.Image = null;
				
				MainForm.timerTiro.Enabled = false;
				
				Destruir();
				
				timerMovimento.Enabled = false;

			}
			
		}

		public void FimdeJogo(){
			
			this.Dispose();
		}
		
		
	}
}
