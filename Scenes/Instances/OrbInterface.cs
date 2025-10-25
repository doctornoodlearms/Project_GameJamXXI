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
                text = $"[pulse][color={PotionHeatStroke.PotionColor.ToHtml()}][b]{PotionHeatStroke.DisplayName}[/b][/color][/pulse]";
                text += "\nIngredients: "+ PotionHeatStroke.IngredientsText;
                break;

            case(PotionHypothermia.Name):
                text = $"[shake][color={PotionHypothermia.PotionColor.ToHtml()}][b]{PotionHypothermia.DisplayName}[/b][/color][/shake]";
                text += "\nIngredients: " + PotionHypothermia.IngredientsText;
                break;
            
            case(PotionStabbed.Name):
                text = $"[wave][color={PotionStabbed.PotionColor.ToHtml()}][b]{PotionStabbed.DisplayName}[/b][/color][/wave]";
                text += "\nIngredients: " + PotionStabbed.IngredientsText;
                break;

            case(PotionSick.Name):
                text = $"[tornado][color={PotionSick.PotionColor.ToHtml()}][b]{PotionSick.DisplayName}[/b][/color][/tornado]";
                text += "\nIngredients: " + PotionSick.IngredientsText;
                break;
        }

        potionText.Text = text;
    }
}
