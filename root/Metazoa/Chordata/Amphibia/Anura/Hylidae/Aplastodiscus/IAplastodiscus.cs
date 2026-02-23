namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Aplastodiscus;

/// <summary>
/// Interface defining characteristics of Aplastodiscus (genus).
/// </summary>
public interface IAplastodiscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
