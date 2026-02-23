using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Zapteryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Zapteryx.unclassified_Zapteryx;

/// <summary>
/// Abstract class for unclassified Zapteryx (no rank).
/// NCBI TaxId: 2677965
/// </summary>
public abstract class unclassified_Zapteryx : Zapteryx, Iunclassified_Zapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zapteryx";
}
