namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae.Bovichtus;

/// <summary>
/// Interface defining characteristics of Bovichtus (genus).
/// </summary>
public interface IBovichtus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
