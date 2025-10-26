public partial class Orb : Area2D{

    [Export] Control popup;

    bool mouse;

    public override void _PhysicsProcess(double delta){

    }

    public override void _Input(InputEvent @event){

        if(@event is InputEventMouseButton mouseButton){

            if(mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed && mouse){

                PopupInterface();
            }
        }
    }

    void PopupInterface(){

        popup.Visible = true;
    }

    void onMouseEntered(){

        mouse = true;
    }

    void onMouseExited(){

        mouse = false;
    }
}
