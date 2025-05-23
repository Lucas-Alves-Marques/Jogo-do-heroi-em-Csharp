﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			Width = 90;
			Height = 70;
			BackColor = Color.Transparent;
			SizeMode = PictureBoxSizeMode.StretchImage;
			Parent = MainForm.Fundo;
		}
		
			public int hp = 100;
			public int ataque = 15;
			public int defesa = 15;
			public int speed = 20;
			public int direcao = 1;
			
			public Timer timerExplosão = new Timer();
			
		void explosão(object sender, EventArgs e){
		
			timerExplosão.Stop();
			Left = 5000;
			Image = null;
		}
		
		public void Destruir()
		{
			Load("explosão2.gif");
			timerExplosão.Enabled = true;
			timerExplosão.Interval = 1500;
			timerExplosão.Tick += explosão;
				
		}
	}
}