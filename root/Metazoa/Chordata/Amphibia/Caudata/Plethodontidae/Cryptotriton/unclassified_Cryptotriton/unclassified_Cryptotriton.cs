using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Cryptotriton;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Cryptotriton.unclassified_Cryptotriton;

/// <summary>
/// Abstract class for unclassified Cryptotriton (no rank).
/// NCBI TaxId: 2641818
/// </summary>
public abstract class unclassified_Cryptotriton : Cryptotriton, Iunclassified_Cryptotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641818;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptotriton";
}
