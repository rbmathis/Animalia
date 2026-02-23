namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Geotrygon;

/// <summary>
/// Interface defining characteristics of Geotrygon (genus).
/// </summary>
public interface IGeotrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
