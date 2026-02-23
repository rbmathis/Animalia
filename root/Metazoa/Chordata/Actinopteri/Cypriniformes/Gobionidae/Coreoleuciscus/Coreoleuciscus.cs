using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Coreoleuciscus;

/// <summary>
/// Abstract class for Coreoleuciscus (genus).
/// NCBI TaxId: 354115
/// </summary>
public abstract class Coreoleuciscus : Gobionidae, ICoreoleuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coreoleuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 354115;

    /// <inheritdoc />
    public virtual string GenusName => "Coreoleuciscus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
