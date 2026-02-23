using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.unclassified_Rhinolophidae;

/// <summary>
/// Abstract class for unclassified Rhinolophidae (no rank).
/// NCBI TaxId: 1296575
/// </summary>
public abstract class unclassified_Rhinolophidae : Rhinolophidae, Iunclassified_Rhinolophidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinolophidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1296575;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinolophidae";
}
