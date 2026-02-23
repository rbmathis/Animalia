namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycophidion;

/// <summary>
/// Interface defining characteristics of Lycophidion (genus).
/// </summary>
public interface ILycophidion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
