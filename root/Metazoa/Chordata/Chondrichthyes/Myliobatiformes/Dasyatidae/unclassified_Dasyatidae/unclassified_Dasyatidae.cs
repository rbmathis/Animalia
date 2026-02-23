using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.unclassified_Dasyatidae;

/// <summary>
/// Abstract class for unclassified Dasyatidae (no rank).
/// NCBI TaxId: 3434765
/// </summary>
public abstract class unclassified_Dasyatidae : Dasyatidae, Iunclassified_Dasyatidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyatidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3434765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyatidae";
}
