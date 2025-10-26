using Definitions.Ingredients;
using Scenes.Instances;
namespace Definitions.Potions;


public partial class PotionStabbed : GodotObject{
    public const string Name = "StabbedPotion";
    public static string DisplayName = "Flower Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientBlorb.Name,
        IngredientEyeball.Name
    };
    public static Color PotionColor = Colors.LightPink;

    public static string Description = "Beauty is in the eye of the beholder";
    public static string IngredientsText = "\nEyeball,\nBlood Orb";
}

public partial class PotionHypothermia : GodotObject
{

    public const string Name = "HypothermiaPotion";
    public static string DisplayName = "Defrost Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientIceShard.Name,
        IngredientSpiritEssence.Name
    };
    public static Color PotionColor = Colors.BlueViolet;
    public static string Description = "Cure a forzen heart";
    public static string IngredientsText = "\nSpirit Essence,\nFrost Essence";
}

public partial class PotionHeatStroke : GodotObject
{

    public const string Name = "HeatStrokePotion";
    public static string DisplayName = "Lemonade Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientFireflies.Name,
        IngredientSpiderString.Name
    };
    public static Color PotionColor = Colors.YellowGreen;
    public static string Description = "A refreshing drink";
    public static string IngredientsText = "\nSpider String,\nFireflies";
}

public partial class PotionSick : GodotObject {

    public const string Name = "SickPotion";
    public static string DisplayName = "Tylenol Potion";

    public static Array<string> Keys = new Array<string>(){

        IngredientSpiritEssence.Name,
        IngredientGraveyardDust.Name
    };
    public static Color PotionColor = Colors.SeaGreen;
    public static string Description = "Cures more then your sickness";
    public static string IngredientsText = "\nGraveyard Dust,\nSpirit Essence";
}