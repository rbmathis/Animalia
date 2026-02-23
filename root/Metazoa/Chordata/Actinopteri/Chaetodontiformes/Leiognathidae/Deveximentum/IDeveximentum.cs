namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Deveximentum;

/// <summary>
/// Interface defining characteristics of Deveximentum (genus).
/// </summary>
public interface IDeveximentum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
