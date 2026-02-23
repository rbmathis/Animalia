namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Tetracheilostoma;

/// <summary>
/// Interface defining characteristics of Tetracheilostoma (genus).
/// </summary>
public interface ITetracheilostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
