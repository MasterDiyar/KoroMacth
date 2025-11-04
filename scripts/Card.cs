using Godot;

namespace machicoro.scripts;

public partial class Card : Node2D
{
    
    public int[] NumberArr = [0, 0];
    public int Output = 0;
    
    public bool CheckCube(int num)
    {
        return NumberArr[0] <= num && num <= NumberArr[1];
    }

    public virtual int GetOutput()
    {
        return Output;
    }
    
}