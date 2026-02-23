namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Oxyura;

/// <summary>
/// Interface defining characteristics of Oxyura (genus).
/// </summary>
public interface IOxyura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
