namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Taenioptynx;

/// <summary>
/// Interface defining characteristics of Taenioptynx (genus).
/// </summary>
public interface ITaenioptynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
