using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Caledoniscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Caledoniscincus.unclassified_Caledoniscincus;

/// <summary>
/// Abstract class for unclassified Caledoniscincus (no rank).
/// NCBI TaxId: 2632714
/// </summary>
public abstract class unclassified_Caledoniscincus : Caledoniscincus, Iunclassified_Caledoniscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caledoniscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632714;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caledoniscincus";
}
