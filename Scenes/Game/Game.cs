public partial class Game:Node{

    PackedScene potionMakingScene;

    [Export] Button nextPageButton;

    public override void _EnterTree(){

        potionMakingScene = GD.Load<PackedScene>(Uids.Uid.PotionMakingScene);
    }
    
    public override void _Ready(){

        nextPageButton.Pressed += onNextButtonPressed;
    }

    void onNextButtonPressed(){

        GetTree().ChangeSceneToPacked(potionMakingScene);
    }
}