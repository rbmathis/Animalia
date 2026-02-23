namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Coradion;

/// <summary>
/// Interface defining characteristics of Coradion (genus).
/// </summary>
public interface ICoradion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
