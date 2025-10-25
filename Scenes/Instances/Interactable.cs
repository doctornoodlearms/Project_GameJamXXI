namespace Scenes.Instances;

[Tool]
public partial class Interactable : RigidBody2D{

    [ExportGroup("Node Ref")]
    [Export] Sprite2D sprite;
    public Texture2D Texture{

        get => sprite.Texture;
        set => sprite.Texture = value;
    }

    Vector2 moveDir;

    bool mouse = false;
    bool followMouse = false;
    float moveSpeed = 500f;

    public override void _Ready(){

        MouseEntered += onMouseEntered;
        MouseExited += onMouseExited;
    }

    public override void _PhysicsProcess(double delta){        

        if(followMouse){

            moveDir = GlobalPosition.DirectionTo(GetGlobalMousePosition());
            float distance = GlobalPosition.DistanceTo(GetGlobalMousePosition());

            if(distance < 10){

                moveDir = Vector2.Zero;
            }

            MoveLocalX(moveDir.X * moveSpeed * (float)delta);
            MoveLocalY(moveDir.Y * moveSpeed * (float)delta);
        }
        moveDir = Vector2.Zero;
    }

    public override void _Input(InputEvent @event){

        if(@event is InputEventMouseButton mouseButton){

            followMouse = mouse && mouseButton.Pressed && mouseButton.ButtonIndex == MouseButton.Left;
            Freeze = followMouse;
        }
    }

    void onMouseEntered(){

        mouse = true;
    }

    void onMouseExited(){

        mouse = false;
    }
}