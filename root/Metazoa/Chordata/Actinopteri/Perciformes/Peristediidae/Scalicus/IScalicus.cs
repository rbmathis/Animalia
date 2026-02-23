namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Scalicus;

/// <summary>
/// Interface defining characteristics of Scalicus (genus).
/// </summary>
public interface IScalicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
