using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.unclassified_Myliobatiformes;

/// <summary>
/// Abstract class for unclassified Myliobatiformes (no rank).
/// NCBI TaxId: 2839948
/// </summary>
public abstract class unclassified_Myliobatiformes : Myliobatiformes, Iunclassified_Myliobatiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myliobatiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839948;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myliobatiformes";
}
