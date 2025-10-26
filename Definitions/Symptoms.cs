using Uids;

namespace Definitions.Symptoms;

public partial class SymptomHypothermia: GodotObject{

    public const string Name = "SymptomHypothermia";
    public static string DisplayName = "Hypothermia";
    public static string Texture = Uid.CustomerHypothermia;
    public static string Description = "";
}
public partial class SymptomHeatStroke: GodotObject{

    public const string Name = "SymptomHeatStroke";
    public static string DisplayName = "Heat Stroke";
    public static string Texture = Uid.CustomerHeatStroke;
    public static string Description = "";
}
public partial class SymptomSick: GodotObject{

    public const string Name = "SymptomSick";
    public static string DisplayName = "Sick";
    public static string Texture = Uid.CustomerSick;
    public static string Description = "";
}
public partial class SymptomStabbed: GodotObject{

    public const string Name = "SymptomStabbed";
    public static string DisplayName = "Stabbed";
    public static string Texture = Uid.CustomerStabbed;
    public static string Description = "";
}