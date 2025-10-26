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

            case(IngredientBlorb.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientBlorb.TextureId);
                break;

            case(IngredientFireflies.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientFireflies.TextureId);
                break;

             case(IngredientIceShard.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientIceShard.TextureId);
                break;
            
             case(IngredientSpiderString.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientSpiderString.TextureId);
                break;
            
             case(IngredientSpiritEssence.Name):
                sprite.Texture = GD.Load<Texture2D>(IngredientSpiritEssence.TextureId);
                break;
        }
    }
}