using Godot;

public class Main : Node2D
{
    public override void _Ready()
    {
        var custom = new CustomNode();
        AddChild(custom);
        var custom_node_script = custom.GetScript() as Script;
        GD.Print( "custom node script path was \"" + custom_node_script.ResourcePath + "\"" );

        var custom2 = GD.Load<CSharpScript>("res://CustomNode.cs").New() as CustomNode;
        AddChild(custom2);
        var custom2_node_script = custom2.GetScript() as Script;
        GD.Print( "Should have been \"" + custom2_node_script.ResourcePath + "\"" );

        //// To save this node as a scene and see the invalid tscn file, uncomment the code below
        //// then go to C:\Users\Cory\AppData\Roaming\Godot\app_userdata\godot_bug_csharp_missing_script_resource_path
        //// and look for 'Main.tscn'
        // custom.Owner = this;
        // custom2.Owner = this;
        // PackedScene scene = new PackedScene();
        // scene.Pack(this);
        // ResourceSaver.Save("user://Main.tscn", scene);
    }
}
