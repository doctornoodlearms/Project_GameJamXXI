using System.ComponentModel.Design;
using Definitions.Potions;
using Definitions.Symptoms;

public partial class OrbInterface : Control{


    [Export] VBoxContainer symptomEntries;
    [Export] VBoxContainer potionEntries;
    [Export] Button closeButton;

    [Export] RichTextLabel potionText;
    [Export] RichTextLabel symptomText;

    Array<string> symptomList = new Array<string>(){

        SymptomHeatStroke.Name, SymptomHypothermia.Name, SymptomSick.Name, SymptomStabbed.Name
    };

    Array<string> potionList = new Array<string>(){

        PotionHeatStroke.Name, PotionHypothermia.Name, PotionSick.Name, PotionStabbed.Name
    };


    public override void _Ready(){
        
        foreach(string potionName in potionList){

            Button potionButton = new Button();
            potionButton.Text = GetPotionDisplayName(potionName);
            potionButton.Pressed += () => onPotionButtonPressed(potionName);
            potionEntries.AddChild(potionButton);
        }
        foreach(string symptomName in symptomList){

            Button symptomButton = new Button();
            symptomButton.Text = GetSymptomDisplayName(symptomName);
            symptomButton.Pressed += () => onSymptomButtonPressed(symptomName);
            symptomEntries.AddChild(symptomButton);
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

    void onSymptomButtonPressed(string symptomName){

        string text = "";
        switch (symptomName)
        {

            case (SymptomHeatStroke.Name):
                text = $"[pulse][color={PotionHeatStroke.PotionColor.ToHtml()}][b]{SymptomHeatStroke.DisplayName}[/b][/color][/pulse]";
                text += "\nDescription: " + SymptomHeatStroke.Description;
                break;

            case (SymptomHypothermia.Name):
                text = $"[shake][color={PotionHypothermia.PotionColor.ToHtml()}][b]{SymptomHypothermia.DisplayName}[/b][/color][/shake]";
                text += "\nDescription: " + SymptomHypothermia.Description;
                break;

            case (SymptomStabbed.Name):
                text = $"[wave][color={PotionStabbed.PotionColor.ToHtml()}][b]{SymptomStabbed.DisplayName}[/b][/color][/wave]";
                text += "\nDescription: " + SymptomStabbed.Description;
                break;

            case (SymptomSick.Name):
                text = $"[tornado][color={PotionSick.PotionColor.ToHtml()}][b]{SymptomSick.DisplayName}[/b][/color][/tornado]";
                text += "\nDescription: " + SymptomSick.Description;
                break;
        }

        symptomText.Text = text;
    }

    void onClosePressed(){

        Visible = false;
    }

    string GetPotionDisplayName(string name){

        switch(name){

            case(PotionHeatStroke.Name):
                return PotionHeatStroke.DisplayName;
            
            case(PotionSick.Name):
                return PotionSick.DisplayName;

            case(PotionStabbed.Name):
                return PotionStabbed.DisplayName;
            
            case(PotionHypothermia.Name):
                return PotionHypothermia.DisplayName;
        }
        return "";
    }

    string GetSymptomDisplayName(string name){

        switch(name){

            case(SymptomHeatStroke.Name):
                return SymptomHeatStroke.DisplayName;
            
            case(SymptomHypothermia.Name):
                return SymptomHypothermia.DisplayName;

            case(SymptomSick.Name):
                return SymptomSick.DisplayName;

            case(SymptomStabbed.Name):
                return SymptomStabbed.DisplayName;
        }
        return "";
    }
}
