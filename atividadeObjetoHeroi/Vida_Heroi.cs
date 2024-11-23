using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{

	public class Vida_Heroi : PictureBox
	{
		public Vida_Heroi()
		{
			Left = 10;
			Top = 260;
			Width = 30;
			Height = 30;
			Load("vida.png");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
	}
}
