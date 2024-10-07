using Godot;

namespace Hastalabrisca.Code.MenuScenes
{
	public partial class MainMenu:Node2D
	{
		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)
		{
		}

		private void _on_play_pressed()
		{
			// Replace with function body.
			GetTree().ChangeSceneToFile("res://Assets/Scenes/GameScenes/Brisca/BriscaScene.tscn");
		}


		private void _on_options_pressed()
		{
			// Replace with function body.
		}


		private void _on_quit_pressed()
		{
			GetTree().Quit();
		}
	}
}
