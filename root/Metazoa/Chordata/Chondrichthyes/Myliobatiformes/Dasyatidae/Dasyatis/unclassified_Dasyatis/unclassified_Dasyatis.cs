using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Dasyatis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Dasyatis.unclassified_Dasyatis;

/// <summary>
/// Abstract class for unclassified Dasyatis (no rank).
/// NCBI TaxId: 2626831
/// </summary>
public abstract class unclassified_Dasyatis : Dasyatis, Iunclassified_Dasyatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626831;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyatis";
}
