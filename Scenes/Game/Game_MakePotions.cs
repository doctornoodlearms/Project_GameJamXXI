public partial class Game_MakePotions : Node{

    PackedScene gameScene;

    [Export] Button button;

    public override void _EnterTree(){

        gameScene = GD.Load<PackedScene>(Uids.Uid.FrontCounterScene);
    }

    public override void _Ready(){

        button.Pressed += onButtonPressed;
    }

    void onButtonPressed(){

        GetTree().ChangeSceneToPacked(gameScene);
    }
}