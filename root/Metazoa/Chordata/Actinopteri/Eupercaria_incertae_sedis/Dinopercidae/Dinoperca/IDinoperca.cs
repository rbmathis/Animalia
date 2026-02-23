namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae.Dinoperca;

/// <summary>
/// Interface defining characteristics of Dinoperca (genus).
/// </summary>
public interface IDinoperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
