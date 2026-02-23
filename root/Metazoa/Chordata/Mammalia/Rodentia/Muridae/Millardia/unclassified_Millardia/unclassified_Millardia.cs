using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Millardia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Millardia.unclassified_Millardia;

/// <summary>
/// Abstract class for unclassified Millardia (no rank).
/// NCBI TaxId: 2652758
/// </summary>
public abstract class unclassified_Millardia : Millardia, Iunclassified_Millardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Millardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2652758;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Millardia";
}
