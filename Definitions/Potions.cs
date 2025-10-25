using Definitions.Ingredients;
namespace Definitions.Potions;

public partial class Potion : GodotObject {

    public const string Name = "Potion";

    public static Array Keys = new Array(){

        IngredientEyeball.Name,
        IngredientGraveyardDust.Name,
		IngredientHolyWater.Name
    };

    public static Color PotionColor = Colors.RebeccaPurple;
}