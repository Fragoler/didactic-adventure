using Content.Shared.FixedPoint;
using Content.Shared.Roles;
using Content.Shared.Storage;
using Robust.Shared.Network;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.GameTicking.Rules.Components;

/// <summary>
/// Gamerule that ends when a player gets a certain number of kills.
/// </summary>
[RegisterComponent, Access(typeof(SpaceTavelSystem))]
public sealed partial class SpaceTravelComponent : Component
{

}
