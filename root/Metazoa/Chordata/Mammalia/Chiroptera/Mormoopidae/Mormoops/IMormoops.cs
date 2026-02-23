namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Mormoops;

/// <summary>
/// Interface defining characteristics of Mormoops (genus).
/// </summary>
public interface IMormoops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
