namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Arctonyx;

/// <summary>
/// Interface defining characteristics of Arctonyx (genus).
/// </summary>
public interface IArctonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
