using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Oreoleuciscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Oreoleuciscus.unclassified_Oreoleuciscus;

/// <summary>
/// Abstract class for unclassified Oreoleuciscus (no rank).
/// NCBI TaxId: 2633170
/// </summary>
public abstract class unclassified_Oreoleuciscus : Oreoleuciscus, Iunclassified_Oreoleuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreoleuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633170;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreoleuciscus";
}
