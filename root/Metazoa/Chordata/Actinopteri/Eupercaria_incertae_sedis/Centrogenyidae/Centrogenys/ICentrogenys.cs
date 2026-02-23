namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Centrogenyidae.Centrogenys;

/// <summary>
/// Interface defining characteristics of Centrogenys (genus).
/// </summary>
public interface ICentrogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
