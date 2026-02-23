using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Uma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Uma.unclassified_Uma;

/// <summary>
/// Abstract class for unclassified Uma (no rank).
/// NCBI TaxId: 3399215
/// </summary>
public abstract class unclassified_Uma : Uma, Iunclassified_Uma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3399215;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uma";
}
