using Robust.Shared.GameObjects;
using Robust.Shared.Utility;

namespace Robust.Shared.EntitySerialization;

/// <summary>Optional content handler for a map file save, before the destination is opened.</summary>
public sealed class MapSaveToPathEvent(EntityUid map, ResPath path, SerializationOptions? options) : EntityEventArgs
{
    public readonly EntityUid Map = map;
    public readonly ResPath Path = path;
    public readonly SerializationOptions? Options = options;
    public bool Handled;
    public bool Success;
}
