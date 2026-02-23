namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Pseudechis;

/// <summary>
/// Interface defining characteristics of Pseudechis (genus).
/// </summary>
public interface IPseudechis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
