using Godot;
using System;
using machicoro.scripts;

public partial class Farmland : GreenCard
{
	public override int[] NumberArr { get; set; } = [1, 2];
	public override int Output { get; set; } = 1;
}
