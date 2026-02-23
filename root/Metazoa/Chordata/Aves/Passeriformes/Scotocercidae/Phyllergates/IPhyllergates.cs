namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Scotocercidae.Phyllergates;

/// <summary>
/// Interface defining characteristics of Phyllergates (genus).
/// </summary>
public interface IPhyllergates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
