﻿using System;
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
			Load("Hero.gif");
			Left = 0;
			Top = 100;
			speed = 20;
			direcao = 1;
			hp = 5;
			Height = 100;
			
		}
		
		public Inimigo inimigo;
		
		public Label FinalMessage = new Label();
		
		public Button reniciar = new Button();
		
		public void MovDir(){
			
			Left += speed;
			
			if (direcao == -1)
			{
				direcao = 1;
				Load("Hero.gif");
			}
			
			if (Left > MainForm.Fundo.Width-20 && inimigo.Image == null) {
			
				Left = 0;
				cenario ++;
				MainForm.Fundo.Load("cenario"+cenario+".gif");
				
				if (cenario == 1) {
				
					inimigo.Load("Boss2.gif");
					inimigo.Left = 570;
					inimigo.timerMovimento.Enabled = true;
					inimigo.speed += 10;
					inimigo.hp = 10;
					MainForm.timerTiro.Enabled = true;
					MainForm.timerTiro.Interval = 1600;
					
					MainForm.Vida_I1_1.Load("vida.png");
					MainForm.Vida_I1_2.Load("vida.png");
					MainForm.Vida_I1_3.Load("vida.png");
					MainForm.Vida_I1_4.Load("vida.png");
					MainForm.Vida_I1_5.Load("vida.png");
					MainForm.Vida_I1_6.Load("vida.png");
					MainForm.Vida_I1_7.Load("vida.png");
					MainForm.Vida_I1_8.Load("vida.png");
					MainForm.Vida_I1_9.Load("vida.png");
					MainForm.Vida_I1_10.Load("vida.png");
					
					
					MainForm.Vida_H_1.Load("vida.png");
					MainForm.Vida_H_2.Load("vida.png");
					MainForm.Vida_H_3.Load("vida.png");
					MainForm.Vida_H_4.Load("vida.png");
					MainForm.Vida_H_5.Load("vida.png");
					
					MainForm.escudo1.Load("defesa.png");
					MainForm.escudo2.Load("defesa.png");
					MainForm.escudo3.Load("defesa.png");
					MainForm.escudo4.Load("defesa.png");
					
					hp = 5;
					
				}
				
				if (cenario == 2) {
					
					inimigo.Load("Boss3.gif");
					inimigo.Left = 570;
					inimigo.timerMovimento.Enabled = true;
					MainForm.timerTiro.Enabled = true;
					inimigo.hp = 12;
					inimigo.Width = 85;
					inimigo.Height = 65;
					MainForm.timerTiro.Interval = 1600;
					
					MainForm.Vida_I1_1.Load("vida.png");
					MainForm.Vida_I1_2.Load("vida.png");
					MainForm.Vida_I1_3.Load("vida.png");
					MainForm.Vida_I1_4.Load("vida.png");
					MainForm.Vida_I1_5.Load("vida.png");
					MainForm.Vida_I1_6.Load("vida.png");
					MainForm.Vida_I1_7.Load("vida.png");
					MainForm.Vida_I1_8.Load("vida.png");
					MainForm.Vida_I1_9.Load("vida.png");
					MainForm.Vida_I1_10.Load("vida.png");
					MainForm.Vida_I1_11.Load("vida.png");
					MainForm.Vida_I1_12.Load("vida.png");
					
					MainForm.Vida_H_1.Load("vida.png");
					MainForm.Vida_H_2.Load("vida.png");
					MainForm.Vida_H_3.Load("vida.png");
					MainForm.Vida_H_4.Load("vida.png");
					MainForm.Vida_H_5.Load("vida.png");
					
					MainForm.escudo1.Load("defesa.png");
					MainForm.escudo2.Load("defesa.png");
					MainForm.escudo3.Load("defesa.png");
					MainForm.escudo4.Load("defesa.png");
					MainForm.escudo5.Load("defesa.png");
					
					hp = 5;
					
					if (Left > MainForm.Fundo.Width) {
						
						Left = 470;
					}
					
				}
				
				if (cenario == 0) {
					
					Left =  MainForm.Fundo.Width;
				}
			}
			
			if (Left > inimigo.Left - 100 && inimigo.Image !=null) {
				
				Left = 450;
			}
			
		}
		
		public void MovEsq(){
			
			Left -= speed;
			
			if (direcao == 1)
			{
				direcao = -1;
			}
			
			if (Left < 0) {
				
				
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
		
		public void PerdeVidas(){
			
			
			if (MainForm.escudo5.Image != null) {
				
				MainForm.escudo5.Image = null;
			}
			
			else if (MainForm.escudo4.Image != null) {
				
				MainForm.escudo4.Image = null;
			}
			
			else if (MainForm.escudo3.Image != null) {
				
				MainForm.escudo3.Image = null;
			}
			
			else if (MainForm.escudo2.Image != null) {
				
				MainForm.escudo2.Image = null;
			}
			
			else if (MainForm.escudo1.Image != null) {
				
				MainForm.escudo1.Image = null;
			}
			
			else if (MainForm.escudo3.Image != null) {
				
				MainForm.escudo3.Image = null;
			}
			
			else if (hp == 5) {
				
				MainForm.Vida_H_5.Image = null;
				hp--;
				MainForm.danoSofrido++;
			}
			
			else if(hp == 4) {
				
				MainForm.Vida_H_4.Image = null;
				hp--;
				MainForm.danoSofrido++;
			}
			
			else if(hp == 3){
				
				MainForm.Vida_H_3.Image = null;
				hp--;
				MainForm.danoSofrido++;
			}
			
			else if (hp == 2) {
				
				MainForm.Vida_H_2.Image = null;
				hp--;
				MainForm.danoSofrido++;
			}
			
			else if (hp == 1) {
			
				MainForm.Vida_H_1.Image = null;
				
				MainForm.timerTiro.Enabled = false;
				
				Destruir();
				
				hp--;
				MainForm.danoSofrido++;
				
				inimigo.Dispose();
				
				
				FinalMessage.Parent = MainForm.Fundo;
				FinalMessage.Text = " VOCE NÃO TEM MAIS VIDAS!! ";
				FinalMessage.ForeColor = Color.White;
				FinalMessage.Left = 265;
				FinalMessage.Top = 122;
				FinalMessage.Width = 165;
				FinalMessage.BackColor = Color.White;
				FinalMessage.Image = Image.FromFile("Fundo_Parte_De_baixo2.png");
			
			
				reniciar.Parent = MainForm.Fundo;
				reniciar.Text = "Reiniciar";
				reniciar.Width = 100;
				reniciar.Left = 300;
				reniciar.Top = 150;
				reniciar.BackColor = Color.White;
				reniciar.Click += reiniciarJogo;
		}
		
		
			}	
		
		public void reiniciarJogo(object sender, EventArgs e)
		{
			Application.Restart();
		}
			
			
		}
		
		
		
}
