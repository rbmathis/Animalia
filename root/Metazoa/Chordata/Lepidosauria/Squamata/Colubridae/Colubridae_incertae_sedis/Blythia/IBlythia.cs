namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Blythia;

/// <summary>
/// Interface defining characteristics of Blythia (genus).
/// </summary>
public interface IBlythia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
