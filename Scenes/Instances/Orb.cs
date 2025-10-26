public partial class Orb : Area2D{

    [Export] Control popup;

    bool mouse;


    public override void _Ready(){

        MouseEntered += onMouseEntered;
        MouseExited += onMouseExited;
    }

    public override void _PhysicsProcess(double delta){

    }

    public override void _Input(InputEvent @event){

        if(mouse ==false) return;
        if(@event is InputEventMouseButton mouseButton){

            if(mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed){

                PopupInterface();
            }
        }
    }

    void PopupInterface(){

        popup.Visible = true;
    }

    void onMouseEntered(){

        Logging.Print("Mouse found");

        mouse = true;
    }

    void onMouseExited(){

        Logging.Print("Mouse lost");

        mouse = false;
    }
}
