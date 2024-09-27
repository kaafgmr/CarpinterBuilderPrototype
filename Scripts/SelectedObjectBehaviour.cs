using Godot;

public partial class SelectedObjectBehaviour : StaticBody3D
{
    [Export] private Node3D gizmo;
    private bool isMouseHovering = false;

    public override void _Ready()
    {
        gizmo.Hide();
    }

    public override void _MouseEnter()
    {
        isMouseHovering = true;
    }

    public override void _MouseExit()
    {
        isMouseHovering = false;
    }
    
    public override void _Input(InputEvent @event)
    {
        bool leftMouseButtonPressed = @event is InputEventMouseButton eventMouseButton && eventMouseButton.ButtonIndex == MouseButton.Left && eventMouseButton.Pressed;

        if(!leftMouseButtonPressed) return;

        if(isMouseHovering)
        {
            gizmo.Show();
        }
        else
        {
            gizmo.Hide();
        }

    }
}
