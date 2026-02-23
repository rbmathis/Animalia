namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Ochotona;

/// <summary>
/// Interface defining characteristics of Ochotona (genus).
/// </summary>
public interface IOchotona
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
