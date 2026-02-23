using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Harrisoniascincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Harrisoniascincus.unclassified_Harrisoniascincus;

/// <summary>
/// Abstract class for unclassified Harrisoniascincus (no rank).
/// NCBI TaxId: 3418346
/// </summary>
public abstract class unclassified_Harrisoniascincus : Harrisoniascincus, Iunclassified_Harrisoniascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harrisoniascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3418346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harrisoniascincus";
}
