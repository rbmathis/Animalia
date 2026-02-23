namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Garrulus;

/// <summary>
/// Interface defining characteristics of Garrulus (genus).
/// </summary>
public interface IGarrulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
