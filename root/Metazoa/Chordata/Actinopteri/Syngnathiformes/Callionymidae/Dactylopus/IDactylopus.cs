namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Dactylopus;

/// <summary>
/// Interface defining characteristics of Dactylopus (genus).
/// </summary>
public interface IDactylopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
