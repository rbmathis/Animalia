namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Corvinella;

/// <summary>
/// Interface defining characteristics of Corvinella (genus).
/// </summary>
public interface ICorvinella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
