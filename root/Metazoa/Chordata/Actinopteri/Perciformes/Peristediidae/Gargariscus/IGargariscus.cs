namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Gargariscus;

/// <summary>
/// Interface defining characteristics of Gargariscus (genus).
/// </summary>
public interface IGargariscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
