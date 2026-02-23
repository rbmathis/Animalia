namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Streptocitta;

/// <summary>
/// Interface defining characteristics of Streptocitta (genus).
/// </summary>
public interface IStreptocitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
