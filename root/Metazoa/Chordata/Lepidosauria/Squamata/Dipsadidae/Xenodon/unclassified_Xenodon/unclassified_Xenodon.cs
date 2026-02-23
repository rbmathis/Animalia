using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenodon.unclassified_Xenodon;

/// <summary>
/// Abstract class for unclassified Xenodon (no rank).
/// NCBI TaxId: 3109754
/// </summary>
public abstract class unclassified_Xenodon : Xenodon, Iunclassified_Xenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3109754;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenodon";
}
