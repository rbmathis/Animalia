namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Malacochersus;

/// <summary>
/// Interface defining characteristics of Malacochersus (genus).
/// </summary>
public interface IMalacochersus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
