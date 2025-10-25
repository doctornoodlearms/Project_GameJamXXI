using Definitions.Potions;

namespace Scenes.Instances;

public partial class Pot : Area2D{

    PackedScene potionInstance;

    [Export] Node2D potionSpawn;
    [Export] int potionIngredientCount;

    Array<string> currentIngredients = new Array<string>();

    Dictionary<string, Array> potionLookup = new Dictionary<string, Array>(){

        {Potion.Name, Potion.Keys}
    };

    public override void _EnterTree(){

        potionInstance = GD.Load<PackedScene>(Uids.Uid.PotionInstance);
    }

    public override void _Ready(){

        BodyEntered += onBodyEntered;
    }

    public override void _Process(double delta){
        
        if(currentIngredients.Count < potionIngredientCount) return;

        PotionInstance instance = potionInstance.Instantiate<PotionInstance>();
        instance.PotionName = GetPotionName();
        potionSpawn.AddChild(instance);

        currentIngredients.Clear();
    }

    void onBodyEntered(Node2D body){

        if (body is Ingredient ingredient){

            currentIngredients.Add(ingredient.ingredientName);

            ingredient.QueueFree();
        }
    }

    string GetPotionName(){

        foreach(string potionName in potionLookup.Keys){

            foreach(string ingredient in currentIngredients){

                if(potionLookup[potionName].Contains(ingredient))continue;
                else break;
            }

            return potionName;
        }
        return "";
    }
}