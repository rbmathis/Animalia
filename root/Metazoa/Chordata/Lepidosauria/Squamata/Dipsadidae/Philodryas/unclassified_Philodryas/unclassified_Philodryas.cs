using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Philodryas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Philodryas.unclassified_Philodryas;

/// <summary>
/// Abstract class for unclassified Philodryas (no rank).
/// NCBI TaxId: 3237379
/// </summary>
public abstract class unclassified_Philodryas : Philodryas, Iunclassified_Philodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Philodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3237379;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Philodryas";
}
