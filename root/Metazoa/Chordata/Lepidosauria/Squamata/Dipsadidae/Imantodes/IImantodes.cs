namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Imantodes;

/// <summary>
/// Interface defining characteristics of Imantodes (genus).
/// </summary>
public interface IImantodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
