using Godot;
using Atko.GDWeaver;

namespace Atko.GDWeaver.Assets
{
	/// <summary>
	/// Node which, when present in the scene tree, will automatically call <see cref="Weaver.Weave"/> on nodes as soon
	/// as they are added to the tree.
	/// </summary>
	public class WeaveListener : AutoWeaverBase
	{
	}
}