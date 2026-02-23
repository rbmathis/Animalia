namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae.Triaenops;

/// <summary>
/// Interface defining characteristics of Triaenops (genus).
/// </summary>
public interface ITriaenops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
