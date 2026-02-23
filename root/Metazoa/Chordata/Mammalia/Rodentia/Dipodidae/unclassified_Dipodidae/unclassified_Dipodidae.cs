using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.unclassified_Dipodidae;

/// <summary>
/// Abstract class for unclassified Dipodidae (no rank).
/// NCBI TaxId: 1147102
/// </summary>
public abstract class unclassified_Dipodidae : Dipodidae, Iunclassified_Dipodidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dipodidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147102;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dipodidae";
}
