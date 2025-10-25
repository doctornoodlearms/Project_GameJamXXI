using Definitions.Ingredients;
namespace Definitions.Potions;


public partial class PotionStabbed : GodotObject{
    public const string Name = "StabbedPotion";
    public static string DisplayName = "Stabbed Potion";

    public static Array Keys = new Array(){

        IngredientEyeball.Name,
        IngredientGraveyardDust.Name,
        SpiderString.Name,
        Blorb.Name
    };
    public static Color PotionColor = Colors.IndianRed;

    public static string Description = "Stabbed Potion";
    public static string IngredientsText = "Eyeball,\nGraveyard Dust,\nSpider String,\nBlood";
}

public partial class PotionHypothermia : GodotObject
{

    public const string Name = "HypothermiaPotion";
    public static string DisplayName = "Hypothemia Potion";

    public static Array Keys = new Array(){

        IngredientEyeball.Name,
        IngredientHolyWater.Name,
        SpiderString.Name,
        IceShard.Name
    };
    public static Color PotionColor = Colors.BlueViolet;
    public static string Description = "Hypothermia Potion";
    public static string IngredientsText = "Eyeball,\nHoly Water,\nSpider String,\nIce Shard";
}

public partial class PotionHeatStroke : GodotObject
{

    public const string Name = "HeatStrokePotion";
    public static string DisplayName = "Heat Stroke Potion";

    public static Array Keys = new Array(){

        WillowBark.Name,
        IngredientGraveyardDust.Name,
        SpiderString.Name,
        Fireflies.Name
    };
    public static Color PotionColor = Colors.Orange;
    public static string Description = "Heat Stroke Potion";
    public static string IngredientsText = "Willow Bark,\nGraveyard Dust,\nSpider String,\nFireflies";
}

public partial class PotionSick : GodotObject {

    public const string Name = "SickPotion";
    public static string DisplayName = "Sick Potion";

    public static Array Keys = new Array(){

        WillowBark.Name,
        IngredientGraveyardDust.Name,
		IngredientHolyWater.Name,
        SpiritEssence.Name
    };
    public static Color PotionColor = Colors.SeaGreen;
    public static string Description = "Sick Potion";
    public static string IngredientsText = "Willow Bark,\nGraveyard Dust,\nHoly Water,\nSpirit Essence";
}