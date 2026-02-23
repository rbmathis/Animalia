using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenopholis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenopholis.unclassified_Xenopholis;

/// <summary>
/// Abstract class for unclassified Xenopholis (no rank).
/// NCBI TaxId: 3109757
/// </summary>
public abstract class unclassified_Xenopholis : Xenopholis, Iunclassified_Xenopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3109757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenopholis";
}
