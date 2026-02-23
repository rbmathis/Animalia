namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Alopochen;

/// <summary>
/// Interface defining characteristics of Alopochen (genus).
/// </summary>
public interface IAlopochen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
