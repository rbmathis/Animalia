namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Goniurosaurus;

/// <summary>
/// Interface defining characteristics of Goniurosaurus (genus).
/// </summary>
public interface IGoniurosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
