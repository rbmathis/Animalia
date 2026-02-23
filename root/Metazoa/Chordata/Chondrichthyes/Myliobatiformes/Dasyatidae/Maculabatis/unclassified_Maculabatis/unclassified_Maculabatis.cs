using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Maculabatis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Maculabatis.unclassified_Maculabatis;

/// <summary>
/// Abstract class for unclassified Maculabatis (no rank).
/// NCBI TaxId: 2720238
/// </summary>
public abstract class unclassified_Maculabatis : Maculabatis, Iunclassified_Maculabatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maculabatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2720238;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maculabatis";
}
