using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Alpinoscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Alpinoscincus.unclassified_Alpinoscincus;

/// <summary>
/// Abstract class for unclassified Alpinoscincus (no rank).
/// NCBI TaxId: 2878437
/// </summary>
public abstract class unclassified_Alpinoscincus : Alpinoscincus, Iunclassified_Alpinoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alpinoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878437;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alpinoscincus";
}
