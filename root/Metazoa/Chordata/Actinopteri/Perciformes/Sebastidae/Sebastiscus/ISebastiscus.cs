namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastiscus;

/// <summary>
/// Interface defining characteristics of Sebastiscus (genus).
/// </summary>
public interface ISebastiscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
