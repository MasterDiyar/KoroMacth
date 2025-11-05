using Godot;
using System;
using machicoro.scripts;

public partial class Game : Node2D
{
	[Export] private Button card, roll;
	[Export] private Node2D spawnNode;
	[Export] private Label outputL, moneyL;

	private RandomNumberGenerator rng;
	public int money = 5, cubeRoll;
	
	private PackedScene[] _scenes =
	[
		GD.Load<PackedScene>("res://scenes/cards/farmland.tscn")
	];

	private int[] _cost =
	[
		1
	];
	public override void _Ready()
	{
		rng = new RandomNumberGenerator();
		rng.Randomize();
		
		card.Pressed += BuyCard;
		roll.Pressed += Roll;
	}

	public override void _Process(double delta)
	{
		moneyL.Text = "money: "+ money;
	}

	void BuyCard()
	{
		if (money < _cost[0]) return;
		money -= _cost[0];
		var Node = _scenes[0].Instantiate<Farmland>();
		Node.Position += Vector2.Right * spawnNode.GetChildCount() * 20 ;
		spawnNode.AddChild(Node);
	}

	void Roll()
	{
		cubeRoll = rng.RandiRange(1, 6);
		outputL.Text = "output: " + cubeRoll;
		
		foreach (var CardNode in spawnNode.GetChildren())
		{
			if (CardNode is Card card && card.CheckCube(cubeRoll))
				money += card.GetOutput();
		}
	}
}
