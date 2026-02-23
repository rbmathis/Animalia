namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Interface defining characteristics of Aotus (genus).
/// </summary>
public interface IAotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
