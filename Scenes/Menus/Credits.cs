using Godot;
using System;
using Uids;

public partial class Credits : Button
{

    PackedScene credits;

    public override void _Ready()
    {
        Pressed += OnPressed;
    }

    public void OnPressed()
    {
        GetTree().ChangeSceneToPacked(credits);
    }

    public override void _EnterTree()
    {
        credits = GD.Load<PackedScene>(Uids.Uid.CreditsScene); 
    }
}

