namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tachyeres;

/// <summary>
/// Interface defining characteristics of Tachyeres (genus).
/// </summary>
public interface ITachyeres
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
