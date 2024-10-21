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
			direcao = "dir";
		}
		
		public void MovDir(){
			
			Left += speed;
			
			if (direcao == "esq")
			{
				direcao = "dir";
				Load("Gargoyle.gif");
			}
			
			if (Left > 570)
			{
				Left = 0;
			}
			
			
		}
		
		public void MovEsq(){
			
			Left -= speed;
			
			if (direcao == "dir")
			{
				direcao = "esq";
				Load("GargoyleEsq.gif");
			}
			
			if (Left < 0)
			{
				Left = 570;
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
	}
}
