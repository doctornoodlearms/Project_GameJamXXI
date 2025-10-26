using Definitions.Potions;
using Scenes.Global;

namespace Scenes.Instances;

public partial class Pot : Area2D{

    PackedScene potionInstance;

    [Export] Array<Shelf> ingredientShelfList;
    [Export] Node2D potionSpawn;
    [Export] int potionIngredientCount;

    Array<string> currentIngredients = new Array<string>();

    Dictionary<string, Array<string>> potionLookup = new Dictionary<string, Array<string>>(){

        {PotionHeatStroke.Name, PotionHeatStroke.Keys},
        {PotionHypothermia.Name, PotionHypothermia.Keys},
        {PotionSick.Name, PotionSick.Keys},
        {PotionStabbed.Name, PotionStabbed.Keys}
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

        CraftedPotions.Self.AddPotion(instance.PotionName);

        potionSpawn.AddChild(instance);

        currentIngredients.Clear();

        foreach(Shelf shelf in ingredientShelfList){

            shelf.RespawnIngredient();
        }
    }

    void onBodyEntered(Node2D body){

        if (body is Ingredient ingredient){

            currentIngredients.Add(ingredient.ingredientName);

            ingredient.QueueFree();
        }
    }

    string GetPotionName(){

        foreach(string potionName in potionLookup.Keys){
            Logging.Print("Checking: "+potionName);

            if(potionLookup[potionName].RecursiveEqual(currentIngredients)){

                return potionName;
            }
        }
        return "";
    }
}