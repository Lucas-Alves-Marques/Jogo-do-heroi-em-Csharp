using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class tiro : PictureBox
	{
		
		Timer tempo = new Timer();
		
		
		public tiro()
		{	
			Load("fireball.gif");
			Left = 90;
			Top = 120;
			Width = 60;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			
			tempo.Enabled = true;
			tempo.Tick += Movimento;

		}
		
		public string direcao = "dir";
		

		
		
		void Movimento(object sender, EventArgs e)
		{	
			if (Left >= MainForm.Fundo.Width) {
				
				tempo.Enabled = false;
				
				MainForm.n_tiros +=1;
				
				Dispose();
			}
			
			if (direcao == "dir") {
				
				Left +=20;
			}
			
			
		}
		
		
		
	}
}
