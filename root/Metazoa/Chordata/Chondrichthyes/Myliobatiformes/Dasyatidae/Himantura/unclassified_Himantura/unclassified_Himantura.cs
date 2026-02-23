using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Himantura;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Himantura.unclassified_Himantura;

/// <summary>
/// Abstract class for unclassified Himantura (no rank).
/// NCBI TaxId: 2633519
/// </summary>
public abstract class unclassified_Himantura : Himantura, Iunclassified_Himantura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Himantura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633519;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Himantura";
}
