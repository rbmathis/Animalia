using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scaptonyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scaptonyx.unclassified_Scaptonyx;

/// <summary>
/// Abstract class for unclassified Scaptonyx (no rank).
/// NCBI TaxId: 2835214
/// </summary>
public abstract class unclassified_Scaptonyx : Scaptonyx, Iunclassified_Scaptonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scaptonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835214;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scaptonyx";
}
