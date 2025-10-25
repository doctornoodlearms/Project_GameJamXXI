using System.Text.Json.Serialization;
using Definitions.Potions;

public partial class OrbInterface : Node{


    [Export] VBoxContainer symptomList;
    [Export] VBoxContainer potionEntries;

    [Export] RichTextLabel potionText;

    Array<string> symptoms = new Array<string>()
    {


    };

    Array<string> potionList = new Array<string>(){

        PotionHeatStroke.Name, PotionHypothermia.Name, PotionSick.Name, PotionStabbed.Name
    };


    public override void _Ready(){
        
        foreach(string potionName in potionList){

            Button potionButton = new Button();
            potionButton.Text = potionName;
            potionButton.Pressed += () => onPotionButtonPressed(potionName);
            potionEntries.AddChild(potionButton);
        }
    }

    void onPotionButtonPressed(string potionName){

        string text = "";
        switch(potionName){

            case(PotionHeatStroke.Name):
                text = PotionHeatStroke.Description;
                break;
                
            case(PotionHypothermia.Name):
                text = PotionHypothermia.Description;
                break;
            
            case(PotionStabbed.Name):
                text = PotionStabbed.Description;
                break;

            case(PotionSick.Name):
                text = PotionSick.Description;
                break;
        }
    }
}
