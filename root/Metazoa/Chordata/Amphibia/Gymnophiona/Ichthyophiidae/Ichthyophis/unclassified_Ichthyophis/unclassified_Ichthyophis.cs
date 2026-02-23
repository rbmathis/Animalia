using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Ichthyophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Ichthyophis.unclassified_Ichthyophis;

/// <summary>
/// Abstract class for unclassified Ichthyophis (no rank).
/// NCBI TaxId: 2634485
/// </summary>
public abstract class unclassified_Ichthyophis : Ichthyophis, Iunclassified_Ichthyophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ichthyophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634485;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ichthyophis";
}
