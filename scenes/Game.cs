using Godot;
using System;

public partial class Game : Node2D
{
	[Export] private Button card;
	public override void _Ready()
	{
		card.Pressed += () => { };
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
