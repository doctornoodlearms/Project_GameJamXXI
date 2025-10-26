using Definitions.Symptoms;
using Scenes.Global;

public partial class CustomerInstance:Area2D{

    [Export] Sprite2D sprite;

    PotionInstance potionInstance;

    string symptomName = "";

    bool potionAccepted = false;

    public override void _Ready(){

        BodyEntered += onBodyEntered;

        CustomerHandler.Self.LoadCustomer();
        LoadCustomer(CustomerHandler.Self.CurrentCustomer);
    }

    public override void _Process(double delta){

        if(potionAccepted){

            CustomerAccept();
        }
    }

    void LoadCustomer(string symptomName){

        switch(symptomName){

            case(SymptomHypothermia.Name):

                sprite.Texture = GD.Load<Texture2D>(SymptomHypothermia.Texture);
                break;
            
            case(SymptomHeatStroke.Name):

                sprite.Texture = GD.Load<Texture2D>(SymptomHeatStroke.Texture);
                break;

            case(SymptomSick.Name):

                sprite.Texture = GD.Load<Texture2D>(SymptomSick.Texture);
                break;

            case(SymptomStabbed.Name):

                sprite.Texture = GD.Load<Texture2D>(SymptomStabbed.Texture);
                break;

        }
        sprite.Visible = true;
        Monitoring = true;
    }

    void CustomerAccept(){

        potionAccepted = false;
        sprite.Visible = false;
        Monitoring = false;
        CraftedPotions.Self.RemovePotion(potionInstance.PotionName);
        potionInstance.QueueFree();
        CustomerHandler.Self.LoadCustomer();
        LoadCustomer(CustomerHandler.Self.CurrentCustomer);
    }

    void onBodyEntered(Node body){

        if(body is PotionInstance instance){

            potionInstance = instance;
            potionAccepted = true;
        }
    }

    void onBodyExited(){

        potionInstance = null;
        potionAccepted = false;
    }
}