namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Arctocebus;

/// <summary>
/// Interface defining characteristics of Arctocebus (genus).
/// </summary>
public interface IArctocebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
