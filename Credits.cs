using Godot;
using System;
using NDLDebug;
using Uids;


public partial class Credits : Control
{
        [Export] Button backButton;

    public override void _Ready(){

        backButton.Pressed += () => GetTree().ChangeSceneToFile(Uid.MenuScene);
    }
}
