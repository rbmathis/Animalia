namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Furipteridae.Furipterus;

/// <summary>
/// Interface defining characteristics of Furipterus (genus).
/// </summary>
public interface IFuripterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
