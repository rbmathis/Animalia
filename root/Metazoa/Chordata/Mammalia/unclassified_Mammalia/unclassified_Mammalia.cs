using AnimalKingdom.root.Metazoa.Chordata.Mammalia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Abstract class for unclassified Mammalia (no rank).
/// NCBI TaxId: 1002697
/// </summary>
public abstract class unclassified_Mammalia : Mammalia, Iunclassified_Mammalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mammalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002697;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mammalia";
}
