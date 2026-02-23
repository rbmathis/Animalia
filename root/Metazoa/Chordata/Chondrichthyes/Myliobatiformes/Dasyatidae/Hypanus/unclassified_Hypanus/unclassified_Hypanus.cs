using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Hypanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Hypanus.unclassified_Hypanus;

/// <summary>
/// Abstract class for unclassified Hypanus (no rank).
/// NCBI TaxId: 3114353
/// </summary>
public abstract class unclassified_Hypanus : Hypanus, Iunclassified_Hypanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3114353;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypanus";
}
