using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class heroi: Personagem
	{	
		public static int cenario = 0;
	
		public heroi()
		{
			Load("Gargoyle.gif");
			Left = 0;
			Top = 100;
			speed = 20;
			direcao = 1;
		}
		
		public Personagem inimigo;
		
		public void MovDir(){
			
			Left += speed;
			
			if (direcao == -1)
			{
				direcao = 1;
				Load("Gargoyle.gif");
			}
			
			if (Left > 570) {
				
				if (cenario == 2) {
					
					Left = 570;
				}
				else {
					
				Left = 0;
				cenario ++;
				MainForm.Fundo.Load("cenario"+cenario+".gif");
				
				}
				
			}
			
		}
		
		public void MovEsq(){
			
			Left -= speed;
			
			if (direcao == 1)
			{
				direcao = -1;
				Load("GargoyleEsq.gif");
			}
			
			if (Left < 0) {
				
				if (cenario == 0) {
					
					Left = 0;
				}
				else {
					
				Left = 570;
				cenario --;
				MainForm.Fundo.Load("cenario"+cenario+".gif");
				
				}
			
			}
		}
		
		public void MovCima(){
			
			Top -= speed;
			
			if (Top <= 0) 
			{	
				Top = 0;
			}
		}
		
		public void MovBaixo(){
			
			Top += speed;
			
			if (Top >= 190) 
			{	
				Top = 190;
			}
		}
		
		public void PerdeVidas(){
			
			if (hp == 0) {
				
				Top = 1000;
				
				MainForm.timerTiro.Enabled = false;
			
				this.Dispose();
				
				inimigo.Dispose();
				
				MessageBox.Show("Voce não tem mais vidas","Sem vidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				
				
			}
			
			hp -= 20;
		}
	}
}
