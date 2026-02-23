using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Kentropyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Kentropyx.unclassified_Kentropyx;

/// <summary>
/// Abstract class for unclassified Kentropyx (no rank).
/// NCBI TaxId: 2646744
/// </summary>
public abstract class unclassified_Kentropyx : Kentropyx, Iunclassified_Kentropyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kentropyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646744;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kentropyx";
}
