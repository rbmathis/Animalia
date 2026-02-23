namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Microcebus;

/// <summary>
/// Interface defining characteristics of Microcebus (genus).
/// </summary>
public interface IMicrocebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
