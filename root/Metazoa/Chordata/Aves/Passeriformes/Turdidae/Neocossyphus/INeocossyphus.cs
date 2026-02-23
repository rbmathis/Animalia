namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Neocossyphus;

/// <summary>
/// Interface defining characteristics of Neocossyphus (genus).
/// </summary>
public interface INeocossyphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
