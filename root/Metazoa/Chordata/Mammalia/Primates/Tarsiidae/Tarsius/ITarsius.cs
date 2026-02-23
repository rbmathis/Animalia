namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Interface defining characteristics of Tarsius (genus).
/// </summary>
public interface ITarsius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
