namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Amarsipidae.Amarsipus;

/// <summary>
/// Interface defining characteristics of Amarsipus (genus).
/// </summary>
public interface IAmarsipus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
