using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes.unclassified_Myodes;

/// <summary>
/// Abstract class for unclassified Myodes (no rank).
/// NCBI TaxId: 2628381
/// </summary>
public abstract class unclassified_Myodes : Myodes, Iunclassified_Myodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628381;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myodes";
}
