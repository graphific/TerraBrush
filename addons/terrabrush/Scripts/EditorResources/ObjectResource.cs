using System;
using Godot;

namespace TerraBrush;

[Tool]
[GlobalClass]
public partial class ObjectResource : Resource
{
    [Export] public ObjectDefinitionResource Definition { get; set; }
    [Export] public bool Hide { get; set; }

    /// <summary>
    /// Controls the visibility of this specific object type in the scene.
    /// Works in conjunction with the global ShowObjects toggle in TerraBrush.
    /// The object is only visible if BOTH this property AND ShowObjects are true.
    /// This allows per-type visibility control for easier scene editing.
    /// </summary>
    [Export] public bool Visible { get; set; } = true;
}
