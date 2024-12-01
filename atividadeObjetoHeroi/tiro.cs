using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class tiro : PictureBox
	{		
		public tiro()
		{   
			Width = 60;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.Fundo;
			timerTiro.Enabled = true;
			timerTiro.Tick += Movimento;
		}
		
		public int direcao = 1;
		public int speed = 30;
		public int dano = 10;
		public Personagem personagemAlvo;
		public Timer timerTiro = new Timer();

		
		void Movimento(object sender, EventArgs e)
		{	
			
			Left += direcao * speed;
			
			if (Left > MainForm.Fundo.Width || Left < 0) {
				
				Destruir();
			}
			
			else if(personagemAlvo.Bounds.IntersectsWith(this.Bounds)){
				
				(personagemAlvo as Inimigo).PerdeVidasInimigo();
				Destruir();
			}
			
			
		}
		
		public void Destruir()
		{
			timerTiro.Enabled = false;
			Left = 600;
			this.Dispose();
			MainForm.listaTiros.Items.Remove(this);
			MainForm.barra.Value += 1;
		}
		
	}
}
