using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Enyalius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Enyalius.unclassified_Enyalius;

/// <summary>
/// Abstract class for unclassified Enyalius (no rank).
/// NCBI TaxId: 2685845
/// </summary>
public abstract class unclassified_Enyalius : Enyalius, Iunclassified_Enyalius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enyalius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enyalius";
}
