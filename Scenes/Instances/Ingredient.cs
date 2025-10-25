using Definitions.Ingredients;

namespace Scenes.Instances;

public partial class Ingredient:Interactable{

    [Export] Sprite2D sprite;
    [Export] public string ingredientName;


    public override void _Ready(){

        SetIngredient(ingredientName);
        base._Ready();
    }

    public void SetIngredient(string name){

        switch(name){

            case (IngredientEyeball.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientEyeball.TextureId);
                break;
            
            case(IngredientGraveyardDust.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientGraveyardDust.TextureId);
                break;

            case(IngredientHolyWater.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientHolyWater.TextureId);
                break;
        }
    }
}