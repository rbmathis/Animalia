namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Lobodon;

/// <summary>
/// Interface defining characteristics of Lobodon (genus).
/// </summary>
public interface ILobodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
