namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cyanochen;

/// <summary>
/// Interface defining characteristics of Cyanochen (genus).
/// </summary>
public interface ICyanochen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
