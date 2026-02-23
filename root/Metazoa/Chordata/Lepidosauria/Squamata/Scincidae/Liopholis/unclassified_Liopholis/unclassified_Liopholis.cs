using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Liopholis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Liopholis.unclassified_Liopholis;

/// <summary>
/// Abstract class for unclassified Liopholis (no rank).
/// NCBI TaxId: 3238789
/// </summary>
public abstract class unclassified_Liopholis : Liopholis, Iunclassified_Liopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3238789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liopholis";
}
