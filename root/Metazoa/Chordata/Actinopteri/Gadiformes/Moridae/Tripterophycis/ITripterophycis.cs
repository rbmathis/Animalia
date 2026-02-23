namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Tripterophycis;

/// <summary>
/// Interface defining characteristics of Tripterophycis (genus).
/// </summary>
public interface ITripterophycis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
