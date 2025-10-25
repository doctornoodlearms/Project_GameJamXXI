using Definitions.Potions;
using Godot;
using Scenes.Global;
using System;

public partial class PotionShelf : StaticBody2D{

    PackedScene potionInstance;

    [Export] Array<Node2D> potionSpawns;

    public override void _Ready(){

        potionInstance = GD.Load<PackedScene>(Uids.Uid.PotionInstance);

        Array<string> potionList = CraftedPotions.Self.GetPotions();

        GD.Print(potionList);
        foreach(string potionName in potionList){

            PotionInstance instance = potionInstance.Instantiate<PotionInstance>();
            instance.PotionName = potionName;
            potionSpawns.PickRandom().AddChild(instance);
        }
    }

}
