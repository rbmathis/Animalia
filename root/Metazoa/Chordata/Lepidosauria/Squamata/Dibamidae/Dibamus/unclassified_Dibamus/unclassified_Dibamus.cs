using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Dibamus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Dibamus.unclassified_Dibamus;

/// <summary>
/// Abstract class for unclassified Dibamus (no rank).
/// NCBI TaxId: 2621817
/// </summary>
public abstract class unclassified_Dibamus : Dibamus, Iunclassified_Dibamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dibamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dibamus";
}
