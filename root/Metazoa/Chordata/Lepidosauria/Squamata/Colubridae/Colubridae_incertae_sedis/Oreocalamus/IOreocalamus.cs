namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Oreocalamus;

/// <summary>
/// Interface defining characteristics of Oreocalamus (genus).
/// </summary>
public interface IOreocalamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
