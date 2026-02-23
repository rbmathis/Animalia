using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Oreoleuciscus;

/// <summary>
/// Abstract class for Oreoleuciscus (genus).
/// NCBI TaxId: 1001946
/// </summary>
public abstract class Oreoleuciscus : Leuciscidae, IOreoleuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreoleuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1001946;

    /// <inheritdoc />
    public virtual string GenusName => "Oreoleuciscus";

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
