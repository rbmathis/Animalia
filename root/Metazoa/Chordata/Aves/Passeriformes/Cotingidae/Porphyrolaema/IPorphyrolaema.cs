namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Porphyrolaema;

/// <summary>
/// Interface defining characteristics of Porphyrolaema (genus).
/// </summary>
public interface IPorphyrolaema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
