using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Batrachoseps;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Batrachoseps.unclassified_Batrachoseps;

/// <summary>
/// Abstract class for unclassified Batrachoseps (no rank).
/// NCBI TaxId: 2621673
/// </summary>
public abstract class unclassified_Batrachoseps : Batrachoseps, Iunclassified_Batrachoseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrachoseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrachoseps";
}
