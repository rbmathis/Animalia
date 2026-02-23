using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.unclassified_Cebidae;

/// <summary>
/// Abstract class for unclassified Cebidae (no rank).
/// NCBI TaxId: 38071
/// </summary>
public abstract class unclassified_Cebidae : Cebidae, Iunclassified_Cebidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cebidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cebidae";
}
