using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Aphyocypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Aphyocypris.unclassified_Aphyocypris;

/// <summary>
/// Abstract class for unclassified Aphyocypris (no rank).
/// NCBI TaxId: 2631739
/// </summary>
public abstract class unclassified_Aphyocypris : Aphyocypris, Iunclassified_Aphyocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphyocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631739;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphyocypris";
}
