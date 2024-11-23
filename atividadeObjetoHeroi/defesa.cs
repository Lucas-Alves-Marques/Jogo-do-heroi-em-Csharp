using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace atividadeObjetoHeroi
{
	/// <summary>
	/// Description of defesa.
	/// </summary>
	public class defesa : PictureBox
	{
		public defesa()
		{
			Left = 13;
			Top = 288;
			Width = 20;
			Height = 20;
			Load("defesa.png");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
	}
}
