namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae.Centrarchops;

/// <summary>
/// Interface defining characteristics of Centrarchops (genus).
/// </summary>
public interface ICentrarchops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
