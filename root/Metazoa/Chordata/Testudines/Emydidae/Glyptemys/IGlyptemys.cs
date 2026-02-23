namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Glyptemys;

/// <summary>
/// Interface defining characteristics of Glyptemys (genus).
/// </summary>
public interface IGlyptemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
