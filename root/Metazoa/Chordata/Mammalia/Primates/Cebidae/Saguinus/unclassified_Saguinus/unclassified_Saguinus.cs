using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus.unclassified_Saguinus;

/// <summary>
/// Abstract class for unclassified Saguinus (no rank).
/// NCBI TaxId: 2642123
/// </summary>
public abstract class unclassified_Saguinus : Saguinus, Iunclassified_Saguinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saguinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642123;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saguinus";
}
