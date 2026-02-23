namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Leposternon;

/// <summary>
/// Interface defining characteristics of Leposternon (genus).
/// </summary>
public interface ILeposternon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
