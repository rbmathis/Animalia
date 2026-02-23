namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Sphaeronycteris;

/// <summary>
/// Interface defining characteristics of Sphaeronycteris (genus).
/// </summary>
public interface ISphaeronycteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
