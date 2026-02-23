namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Metacrinia;

/// <summary>
/// Interface defining characteristics of Metacrinia (genus).
/// </summary>
public interface IMetacrinia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
