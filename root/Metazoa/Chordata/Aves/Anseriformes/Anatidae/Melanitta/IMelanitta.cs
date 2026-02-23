namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Melanitta;

/// <summary>
/// Interface defining characteristics of Melanitta (genus).
/// </summary>
public interface IMelanitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
