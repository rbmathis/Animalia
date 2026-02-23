namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Sicista;

/// <summary>
/// Interface defining characteristics of Sicista (genus).
/// </summary>
public interface ISicista
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
