namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Jordaniidae.Jordania;

/// <summary>
/// Interface defining characteristics of Jordania (genus).
/// </summary>
public interface IJordania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
