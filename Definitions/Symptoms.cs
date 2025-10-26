using Uids;

namespace Definitions.Symptoms;

public partial class SymptomHypothermia: GodotObject{

    public const string Name = "SymptomHypothermia";
    public static string DisplayName = "Hypothermia";
    public static string Texture = Uid.CustomerHypothermia;
    public static string Description = "They have been frozen solid long enough to cease bodily function";
}
public partial class SymptomHeatStroke: GodotObject{

    public const string Name = "SymptomHeatStroke";
    public static string DisplayName = "Heat Stroke";
    public static string Texture = Uid.CustomerHeatStroke;
    public static string Description = "They have experienced heat strong enough to melt their body";
}
public partial class SymptomSick: GodotObject{

    public const string Name = "SymptomSick";
    public static string DisplayName = "Sick";
    public static string Texture = Uid.CustomerSick;
    public static string Description = "They have caught a horrific disease causing their soul to leave their body";
}
public partial class SymptomStabbed: GodotObject{

    public const string Name = "SymptomStabbed";
    public static string DisplayName = "Stabbed";
    public static string Texture = Uid.CustomerStabbed;
    public static string Description = "They have the misfortune of causing various stabbings";
}