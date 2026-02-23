namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Ramphocaenus;

/// <summary>
/// Interface defining characteristics of Ramphocaenus (genus).
/// </summary>
public interface IRamphocaenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
