namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae.Kentrocapros;

/// <summary>
/// Interface defining characteristics of Kentrocapros (genus).
/// </summary>
public interface IKentrocapros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
