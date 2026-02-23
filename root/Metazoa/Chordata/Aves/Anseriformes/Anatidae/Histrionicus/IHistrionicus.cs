namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Histrionicus;

/// <summary>
/// Interface defining characteristics of Histrionicus (genus).
/// </summary>
public interface IHistrionicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
