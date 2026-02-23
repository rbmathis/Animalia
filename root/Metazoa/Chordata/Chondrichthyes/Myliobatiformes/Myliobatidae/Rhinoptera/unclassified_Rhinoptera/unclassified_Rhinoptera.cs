using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Rhinoptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Rhinoptera.unclassified_Rhinoptera;

/// <summary>
/// Abstract class for unclassified Rhinoptera (no rank).
/// NCBI TaxId: 2603169
/// </summary>
public abstract class unclassified_Rhinoptera : Rhinoptera, Iunclassified_Rhinoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2603169;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinoptera";
}
