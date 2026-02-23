namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris;

/// <summary>
/// Interface defining characteristics of Nycteris (genus).
/// </summary>
public interface INycteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
