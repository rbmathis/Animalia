using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.unclassified_Myctophidae;

/// <summary>
/// Abstract class for unclassified Myctophidae (no rank).
/// NCBI TaxId: 184218
/// </summary>
public abstract class unclassified_Myctophidae : Myctophidae, Iunclassified_Myctophidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myctophidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184218;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myctophidae";
}
