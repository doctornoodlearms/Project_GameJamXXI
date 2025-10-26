using NDLDebug;
using Uids;

public partial class Main : Node {

	[Export] Button playButton;
    [Export] Button creditsButton;
    [Export] Button quitButton;

    public override void _Ready() {

        playButton.Pressed += () => GetTree().ChangeSceneToFile(Uid.FrontCounterScene);
        creditsButton.Pressed += () => GetTree().ChangeSceneToFile(Uid.CreditsScene);
        quitButton.Pressed += () => GetTree().Quit();
    }
}
