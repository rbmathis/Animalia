using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Sminthopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Sminthopsis.unclassified_Sminthopsis;

/// <summary>
/// Abstract class for unclassified Sminthopsis (no rank).
/// NCBI TaxId: 2641479
/// </summary>
public abstract class unclassified_Sminthopsis : Sminthopsis, Iunclassified_Sminthopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sminthopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641479;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sminthopsis";
}
