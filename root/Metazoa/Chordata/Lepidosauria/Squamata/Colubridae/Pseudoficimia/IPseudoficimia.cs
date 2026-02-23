namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudoficimia;

/// <summary>
/// Interface defining characteristics of Pseudoficimia (genus).
/// </summary>
public interface IPseudoficimia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
