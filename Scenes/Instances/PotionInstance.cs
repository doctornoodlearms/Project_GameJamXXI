using Definitions.Potions;
using Scenes.Instances;

public partial class PotionInstance : Interactable{


    [Export] Sprite2D sprite;

    public string PotionName = "";

    public override void _Ready(){

        SetPotion(PotionName);
        base._Ready();
    }

    void SetPotion(string name){

        switch(name){

            case(Potion.Name):

                sprite.Modulate = Potion.PotionColor;
                break;
        }

    }
}