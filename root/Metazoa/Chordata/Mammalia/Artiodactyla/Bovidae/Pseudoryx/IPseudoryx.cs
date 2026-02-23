namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudoryx;

/// <summary>
/// Interface defining characteristics of Pseudoryx (genus).
/// </summary>
public interface IPseudoryx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
