using Godot;
using System;
using machicoro.scripts;

public partial class Mill : GreenCard
{
	public override int[] NumberArr { get; set; } = [3, 3];
	public override int Output { get; set; } = 1;

	public override int GetOutput()
	{
		Node parent = GetParent();

		int farmCount = 0;
		foreach (var card in  parent.GetChildren())
		{
			if (card is Farmland farm)
				farmCount++;
		}
		
		return farmCount*Output;
	}
}
