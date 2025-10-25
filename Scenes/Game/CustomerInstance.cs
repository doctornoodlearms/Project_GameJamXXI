using Definitions.Customers;
using Scenes.Global;

public partial class CustomerInstance:Area2D{

    [Export] Sprite2D sprite;

    PotionInstance potionInstance;

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

    void LoadCustomer(string customerName){

        switch(customerName){

            case(Customer.Name):

                sprite.Texture = GD.Load<Texture2D>(Customer.Texture);
                sprite.Visible = true;
                Monitoring = true;
                break;

        }
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