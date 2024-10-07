using Godot;
using System;
using System.Collections.Generic;

namespace Hastalabrisca.Code.GameScenes.Brisca
{
	public partial class BriscaScene: Node2D
	{
		List<int> AvailableCards;

		//Called when the node enters the scene for the first time.
		public override void _Ready()
		{
			base._Ready();
		}

		//Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)
		{
			base._Process(delta);
		}

		private void RepartirCartas()
		{
			AvailableCards = new List<int>();
			for (int i = 0; i<40; i++)
			{
				AvailableCards.Add(i);
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					int cartaRepartida = AvailableCards[1+GD.RandRange(0,AvailableCards.Count-1)];
					GD.Print("Carta " + (j+1) + " del jugador " + (i+1) + ": " + cartaRepartida+", el " + Enum.GetName(typeof(BarajaEspanola),cartaRepartida));
					AvailableCards.Remove(cartaRepartida);
				}
			}
		}

		private void _on_texture_button_pressed()
		{
			GD.Print("Reparto cartas");
			Array valores = Enum.GetValues(typeof(BarajaEspanola));
			Random rand = new Random();
			string url = EnumHelper.GetSpriteURLValue((BarajaEspanola)valores.GetValue(1+rand.Next(valores.Length-1)));
			Texture2D newTexture = (Texture2D)GD.Load(url);
			((TextureButton)GetNode("TextureButton")).TextureNormal= newTexture;
			RepartirCartas();
		}
	}
}
