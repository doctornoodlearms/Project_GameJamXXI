using Definitions.Ingredients;
using Scenes.Instances;

public partial class Shelf : StaticBody2D {

    [Export] Node2D IngredientSpawn;

    [Export] string ingredientName;

    Ingredient ingredientRef;

    PackedScene ingredientInstance;

    public override void _EnterTree(){

        ingredientInstance = GD.Load<PackedScene>(Uids.Uid.IngredientInstance);
    }

    public override void _Ready(){

        RespawnIngredient();
    }

    public void RespawnIngredient(){

        if(IsInstanceValid(ingredientRef)){

            ingredientRef.QueueFree();
        }

        Ingredient instance = ingredientInstance.Instantiate<Ingredient>();
        instance.ingredientName = ingredientName;
        ingredientRef = instance;
        IngredientSpawn.AddChild(instance);
    }
}
