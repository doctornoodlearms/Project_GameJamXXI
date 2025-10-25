using Definitions.Ingredients;
namespace Definitions.Potions;


public partial class PotionStabbed : GodotObject
{

    public const string Name = "StabbedPotion";

    public static Array Keys = new Array(){

        IngredientEyeball.Name,
        IngredientGraveyardDust.Name,
        SpiderString.Name,
        Blorb.Name
    };

    public static Color PotionColor = Colors.IndianRed;
}

public partial class PotionHypothermia : GodotObject
{

    public const string Name = "HypothermiaPotion";

    public static Array Keys = new Array(){

        IngredientEyeball.Name,
        IngredientHolyWater.Name,
        SpiderString.Name,
        IceShard.Name
    };

    public static Color PotionColor = Colors.BlueViolet;
}

public partial class PotionHeatStroke : GodotObject
{

    public const string Name = "HeatStrokePotion";

    public static Array Keys = new Array(){

        WillowBark.Name,
        IngredientGraveyardDust.Name,
        SpiderString.Name,
        Fireflies.Name
    };

    public static Color PotionColor = Colors.Orange;
}

public partial class PotionSick : GodotObject {

    public const string Name = "SickPotion";

    public static Array Keys = new Array(){

        WillowBark.Name,
        IngredientGraveyardDust.Name,
		IngredientHolyWater.Name,
        SpiritEssence.Name
    };

    public static Color PotionColor = Colors.WhiteSmoke;
}