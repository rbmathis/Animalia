namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae.Aetapcus;

/// <summary>
/// Interface defining characteristics of Aetapcus (genus).
/// </summary>
public interface IAetapcus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
