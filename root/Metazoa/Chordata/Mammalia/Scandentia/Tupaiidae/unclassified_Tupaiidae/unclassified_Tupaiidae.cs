using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.unclassified_Tupaiidae;

/// <summary>
/// Abstract class for unclassified Tupaiidae (no rank).
/// NCBI TaxId: 1002720
/// </summary>
public abstract class unclassified_Tupaiidae : Tupaiidae, Iunclassified_Tupaiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tupaiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tupaiidae";
}
