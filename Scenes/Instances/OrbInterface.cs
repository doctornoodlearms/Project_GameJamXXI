using Definitions.Potions;

public partial class OrbInterface : Control{


    [Export] VBoxContainer symptomList;
    [Export] VBoxContainer potionEntries;
    [Export] Button closeButton;

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

        closeButton.Pressed += onClosePressed;
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

    void onClosePressed(){

        Visible = false;
    }
}
