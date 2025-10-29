using System;
using Godot;

namespace TerraBrush;

[Tool]
[GlobalClass]
public partial class FoliageResource : Resource
{
    [Export] public FoliageDefinitionResource Definition { get; set; }

    /// <summary>
    /// Controls the visibility of this specific foliage type in the scene.
    /// Works in conjunction with the global ShowFoliage toggle in TerraBrush.
    /// The foliage is only visible if BOTH this property AND ShowFoliage are true.
    /// This allows per-type visibility control for easier scene editing.
    /// </summary>
    [Export] public bool Visible { get; set; } = true;
}
