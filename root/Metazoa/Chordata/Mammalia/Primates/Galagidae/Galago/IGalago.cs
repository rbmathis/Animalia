namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galago;

/// <summary>
/// Interface defining characteristics of Galago (genus).
/// </summary>
public interface IGalago
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
