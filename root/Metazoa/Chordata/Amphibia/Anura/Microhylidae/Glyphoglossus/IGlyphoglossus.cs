namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus;

/// <summary>
/// Interface defining characteristics of Glyphoglossus (genus).
/// </summary>
public interface IGlyphoglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
