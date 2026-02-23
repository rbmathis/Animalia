using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis.unclassified_Myliobatis;

/// <summary>
/// Abstract class for unclassified Myliobatis (no rank).
/// NCBI TaxId: 2648700
/// </summary>
public abstract class unclassified_Myliobatis : Myliobatis, Iunclassified_Myliobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myliobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648700;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myliobatis";
}
