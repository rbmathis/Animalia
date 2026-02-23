namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Pteronotus;

/// <summary>
/// Interface defining characteristics of Pteronotus (genus).
/// </summary>
public interface IPteronotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
