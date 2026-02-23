namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Cyanocompsa;

/// <summary>
/// Interface defining characteristics of Cyanocompsa (genus).
/// </summary>
public interface ICyanocompsa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
