namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Oxyrhopus;

/// <summary>
/// Interface defining characteristics of Oxyrhopus (genus).
/// </summary>
public interface IOxyrhopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
