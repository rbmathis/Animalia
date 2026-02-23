namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae.Rhinonicteris;

/// <summary>
/// Interface defining characteristics of Rhinonicteris (genus).
/// </summary>
public interface IRhinonicteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
