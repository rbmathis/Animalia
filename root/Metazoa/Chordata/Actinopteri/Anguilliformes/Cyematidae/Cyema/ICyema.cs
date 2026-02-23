namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Cyema;

/// <summary>
/// Interface defining characteristics of Cyema (genus).
/// </summary>
public interface ICyema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
