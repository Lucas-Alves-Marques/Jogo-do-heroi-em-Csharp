using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class heroi: Personagem
	{	
		public heroi()
		{
			Load("Gargoyle.gif");
			Left = 0;
			Top = 100;
			speed = 20;
			direcao = 1;
		}
		
		public Personagem inimigo;
		
		int cenario = 0;
		
		public void MovDir(){
			
			Left += speed;
			
			if (direcao == -1)
			{
				direcao = 1;
				Load("Gargoyle.gif");
			}
			
			if (Left > 570 && cenario!= 2)
			{
				Left = 0;
				
				if (cenario  == 0) {
					
					MainForm.Fundo.Load("cenario1.gif");
					cenario = 1;
				}
				
				if (cenario == 1) {
					
					MainForm.Fundo.Load("cenario2.gif");
					cenario = 2;
				}
			}
			
			if (Left > 570 && cenario == 2) {
				
				Left = 570;
			}
			
			
		}
		
		public void MovEsq(){
			
			Left -= speed;
			
			if (direcao == 1)
			{
				direcao = -1;
				Load("GargoyleEsq.gif");
			}
			
			if (Left < 0 && cenario != 0)
			{
				if (cenario == 2) {
					
					MainForm.Fundo.Load("cenario1.gif");
					Left = 570;
					cenario = 1;
				}
				
				if (cenario == 1) {
					
					MainForm.Fundo.Load("cenario0.gif");
					Left = 570;
					cenario = 0;
				}
				
			}
			
			if (Left < 0 && cenario == 0){
				
				Left = 0;
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
		
		public void Tiro(){
			
			tiro fireboll = new tiro();
			fireboll.Left = Left;
			fireboll.Top = Top + 20;
			fireboll.Parent = MainForm.Fundo;
			
			fireboll.direcao = direcao;
			
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
