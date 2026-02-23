namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

/// <summary>
/// Interface defining characteristics of Atelopus (genus).
/// </summary>
public interface IAtelopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
