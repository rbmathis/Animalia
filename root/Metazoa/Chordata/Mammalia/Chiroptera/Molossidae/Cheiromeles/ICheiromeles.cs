namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Cheiromeles;

/// <summary>
/// Interface defining characteristics of Cheiromeles (genus).
/// </summary>
public interface ICheiromeles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
