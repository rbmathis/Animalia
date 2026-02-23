using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Austrochaperina;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Austrochaperina.unclassified_Austrochaperina;

/// <summary>
/// Abstract class for unclassified Austrochaperina (no rank).
/// NCBI TaxId: 2633551
/// </summary>
public abstract class unclassified_Austrochaperina : Austrochaperina, Iunclassified_Austrochaperina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Austrochaperina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633551;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Austrochaperina";
}
