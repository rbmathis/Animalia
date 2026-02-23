namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Scaphiophryne;

/// <summary>
/// Interface defining characteristics of Scaphiophryne (genus).
/// </summary>
public interface IScaphiophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
