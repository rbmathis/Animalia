namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Plagiogeneion;

/// <summary>
/// Interface defining characteristics of Plagiogeneion (genus).
/// </summary>
public interface IPlagiogeneion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
