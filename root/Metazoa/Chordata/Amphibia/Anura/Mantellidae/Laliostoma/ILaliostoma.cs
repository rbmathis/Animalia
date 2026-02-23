namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Laliostoma;

/// <summary>
/// Interface defining characteristics of Laliostoma (genus).
/// </summary>
public interface ILaliostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
