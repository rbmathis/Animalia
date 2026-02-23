using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.unclassified_Rajidae;

/// <summary>
/// Abstract class for unclassified Rajidae (no rank).
/// NCBI TaxId: 1072464
/// </summary>
public abstract class unclassified_Rajidae : Rajidae, Iunclassified_Rajidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rajidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1072464;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rajidae";
}
