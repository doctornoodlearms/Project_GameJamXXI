using Definitions.Ingredients;
using Scenes.Instances;

public partial class Shelf : StaticBody2D {

    [Export] Node2D IngredientSpawn;
    [Export] Node2D IngredientSpawn2;

    [Export] string ingredientName;
    [Export] string ingredientName2;

    Ingredient ingredientRef1;
    Ingredient ingredientRef2;

    PackedScene ingredientInstance;

    public override void _EnterTree(){

        ingredientInstance = GD.Load<PackedScene>(Uids.Uid.IngredientInstance);
    }

    public override void _Ready(){

        RespawnIngredient();
    }

    public void RespawnIngredient(){

        if(IsInstanceValid(ingredientRef1)){

            ingredientRef1.QueueFree();
        }

        Ingredient instance = ingredientInstance.Instantiate<Ingredient>();
        instance.ingredientName = ingredientName;
        ingredientRef1 = instance;
        IngredientSpawn.AddChild(instance);

        if(IsInstanceValid(ingredientRef2)){

            ingredientRef2.QueueFree();
        }

        Ingredient instance2 = ingredientInstance.Instantiate<Ingredient>();
        instance2.ingredientName = ingredientName2;
        ingredientRef2 = instance2;
        IngredientSpawn2.AddChild(instance2);
    }
}
