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

            case(PotionHeatStroke.Name):

                sprite.Modulate = PotionHeatStroke.PotionColor;
                break;

            case(PotionHypothermia.Name):

                sprite.Modulate = PotionHypothermia.PotionColor;
                break;

            case(PotionSick.Name):

                sprite.Modulate = PotionSick.PotionColor;
                break;

            case(PotionStabbed.Name):

                sprite.Modulate = PotionStabbed.PotionColor;
                break;
            

        }

    }
}