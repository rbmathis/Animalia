namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mysticellus;

/// <summary>
/// Interface defining characteristics of Mysticellus (genus).
/// </summary>
public interface IMysticellus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
