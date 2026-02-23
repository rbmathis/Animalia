namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Radjah;

/// <summary>
/// Interface defining characteristics of Radjah (genus).
/// </summary>
public interface IRadjah
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
