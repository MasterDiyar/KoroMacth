using Godot;

namespace machicoro.scripts;

public partial class Card : Node2D
{

    public virtual int[] NumberArr { get; set; } = [0, 0];
    public virtual int Output { get; set; } = 0;

    private Area2D area;

    public override void _Ready()
    {
        area = GetNode<Area2D>("Area2D");
        area.MouseEntered += Light;
        area.MouseExited += Dark;
    }

    void Light()
    {
        Modulate = new Color(1.2f, 1.2f, 1.2f);
        Scale = Vector2.One * 1.2f;
        ZIndex = 100;
    }

    void Dark()
    {
        Modulate = new Color(1, 1, 1);
        Scale = Vector2.One;
        ZIndex = 0;
    }

    public bool CheckCube(int num)
    {
        GD.Print(num, NumberArr[0], NumberArr[1]);
        return NumberArr[0] <= num && num <= NumberArr[1];
    }

    public virtual int GetOutput()
    {
        return Output;
    }
    
}