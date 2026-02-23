namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Paragalago;

/// <summary>
/// Interface defining characteristics of Paragalago (genus).
/// </summary>
public interface IParagalago
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
