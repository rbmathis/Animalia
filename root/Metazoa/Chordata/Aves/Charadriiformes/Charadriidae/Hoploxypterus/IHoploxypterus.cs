namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Hoploxypterus;

/// <summary>
/// Interface defining characteristics of Hoploxypterus (genus).
/// </summary>
public interface IHoploxypterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
