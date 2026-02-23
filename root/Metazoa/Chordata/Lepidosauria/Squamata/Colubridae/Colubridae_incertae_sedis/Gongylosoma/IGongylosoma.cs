namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Gongylosoma;

/// <summary>
/// Interface defining characteristics of Gongylosoma (genus).
/// </summary>
public interface IGongylosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
