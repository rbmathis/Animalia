using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Toxicocalamus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Toxicocalamus.unclassified_Toxicocalamus;

/// <summary>
/// Abstract class for unclassified Toxicocalamus (no rank).
/// NCBI TaxId: 2624119
/// </summary>
public abstract class unclassified_Toxicocalamus : Toxicocalamus, Iunclassified_Toxicocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Toxicocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Toxicocalamus";
}
