using Definitions.Ingredients;
using Scenes.Instances;
namespace Definitions.Potions;


public partial class PotionStabbed : GodotObject{
    public const string Name = "StabbedPotion";
    public static string DisplayName = "Stabbed Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientBlorb.Name,
        IngredientEyeball.Name
    };
    public static Color PotionColor = Colors.IndianRed;

    public static string Description = "Stabbed Potion";
    public static string IngredientsText = "\nEyeball,\nBlood Orb";
}

public partial class PotionHypothermia : GodotObject
{

    public const string Name = "HypothermiaPotion";
    public static string DisplayName = "Hypothemia Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientIceShard.Name,
        IngredientSpiritEssence.Name
    };
    public static Color PotionColor = Colors.BlueViolet;
    public static string Description = "Hypothermia Potion";
    public static string IngredientsText = "\nSpirit Essence,\nFrost Essence";
}

public partial class PotionHeatStroke : GodotObject
{

    public const string Name = "HeatStrokePotion";
    public static string DisplayName = "Heat Stroke Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientFireflies.Name,
        IngredientSpiderString.Name
    };
    public static Color PotionColor = Colors.Orange;
    public static string Description = "Heat Stroke Potion";
    public static string IngredientsText = "\nSpider String,\nFireflies";
}

public partial class PotionSick : GodotObject {

    public const string Name = "SickPotion";
    public static string DisplayName = "Sick Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientSpiritEssence.Name,
        IngredientGraveyardDust.Name
    };
    public static Color PotionColor = Colors.SeaGreen;
    public static string Description = "Sick Potion";
    public static string IngredientsText = "\nGraveyard Dust,\nSpirit Essence";
}