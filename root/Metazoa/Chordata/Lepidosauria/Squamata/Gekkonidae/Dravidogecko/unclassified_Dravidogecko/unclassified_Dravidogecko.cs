using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dravidogecko;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dravidogecko.unclassified_Dravidogecko;

/// <summary>
/// Abstract class for unclassified Dravidogecko (no rank).
/// NCBI TaxId: 2651358
/// </summary>
public abstract class unclassified_Dravidogecko : Dravidogecko, Iunclassified_Dravidogecko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dravidogecko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dravidogecko";
}
