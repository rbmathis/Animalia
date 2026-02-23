namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinopomatidae.Rhinopoma;

/// <summary>
/// Interface defining characteristics of Rhinopoma (genus).
/// </summary>
public interface IRhinopoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
