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
		
		public Label Vencedor = new Label();
		
		public Label danoTotal = new Label();
		
		public Button reniciar = new Button();
		
		public tiroInimigo rajada;
		
		public heroi julio;
		
		public Timer timerMovimento = new Timer();
		
		void Movimento(object sender, EventArgs e)
		{
			Top += speed * direcaoVertical;
		
			
			if(Top >= 180) {
				direcaoVertical = -1;
			}
			
			if (Top <= 0) 
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

				

				if (heroi.cenario == 2) {
					
					JogoVencido();
				}

				Destruir();
				
				timerMovimento.Enabled = false;

			}
			
		}

		public void FimdeJogo(){
			
			this.Dispose();
		}
		
		public void JogoVencido(){
			
			Vencedor.Parent = MainForm.Fundo;
			Vencedor.Text = "Parabens!! Voce venceu !!";
			Vencedor.Left = 280;
			Vencedor.Top = 100;
			Vencedor.Width = 150;
			Vencedor.BackColor = Color.White;
			Vencedor.ForeColor = Color.White;
			Vencedor.Image = Image.FromFile("Fundo_Parte_De_baixo2.png");
			
			danoTotal.Parent = MainForm.Fundo;
			danoTotal.Text = "Total de Dano Direto Recebido foi de " + MainForm.danoSofrido + " pontos de HP";
			danoTotal.Left = 210;
			danoTotal.Top = 122;
			danoTotal.Width = 270;
			danoTotal.ForeColor = Color.White;
			danoTotal.Image = Image.FromFile("Fundo_Parte_De_baixo2.png");
			
			reniciar.Parent = MainForm.Fundo;
			reniciar.Text = "Reiniciar";
			reniciar.Width = 100;
			reniciar.Left = 300;
			reniciar.Top = 150;
			reniciar.BackColor = Color.White;
			reniciar.Click += reiniciarJogo;
		}
		
		
		public void reiniciarJogo(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
