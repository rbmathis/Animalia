using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ailuronyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ailuronyx.unclassified_Ailuronyx;

/// <summary>
/// Abstract class for unclassified Ailuronyx (no rank).
/// NCBI TaxId: 2629654
/// </summary>
public abstract class unclassified_Ailuronyx : Ailuronyx, Iunclassified_Ailuronyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ailuronyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629654;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ailuronyx";
}
