using Godot;
using System;
using NDLDebug;
using Uids;

public partial class Audio : AudioStreamPlayer
{
    public override void _Ready()
    {
        Stream = GD.Load<AudioStream>(Uid.Music);
        Play();
    }
}
