namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Holacanthus;

/// <summary>
/// Interface defining characteristics of Holacanthus (genus).
/// </summary>
public interface IHolacanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
