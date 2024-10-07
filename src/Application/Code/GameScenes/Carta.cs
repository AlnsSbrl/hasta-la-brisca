using Godot;
using Hastalabrisca.Code.GameScenes;

namespace Hastalabrisca.Code
{
	
	public partial class Carta: TextureButton
	{
		private int Score;
		public int GetScore() 
		{
			return Score; 
		}
		public void SetScore(int Score)
		{
			this.Score = Score;
		}

		public void ShowDorso()
		{
			string URL = EnumHelper.GetSpriteURLValue(Dorsos.DORSO_BASICO);
			Texture2D NewTexture = (Texture2D)GD.Load(URL);
			((TextureButton)GetNode("TextureButton")).TextureNormal = NewTexture;
		}
	   
	}
}
