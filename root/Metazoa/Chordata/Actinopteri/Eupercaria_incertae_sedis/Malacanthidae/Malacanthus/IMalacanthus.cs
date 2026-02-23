namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Malacanthus;

/// <summary>
/// Interface defining characteristics of Malacanthus (genus).
/// </summary>
public interface IMalacanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
