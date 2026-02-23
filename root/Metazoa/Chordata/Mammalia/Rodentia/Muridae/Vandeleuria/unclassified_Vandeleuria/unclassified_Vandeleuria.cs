using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vandeleuria;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vandeleuria.unclassified_Vandeleuria;

/// <summary>
/// Abstract class for unclassified Vandeleuria (no rank).
/// NCBI TaxId: 2629328
/// </summary>
public abstract class unclassified_Vandeleuria : Vandeleuria, Iunclassified_Vandeleuria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vandeleuria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629328;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vandeleuria";
}
