namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tadorna;

/// <summary>
/// Interface defining characteristics of Tadorna (genus).
/// </summary>
public interface ITadorna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
