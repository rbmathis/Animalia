using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Paramesotriton;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Paramesotriton.unclassified_Paramesotriton;

/// <summary>
/// Abstract class for unclassified Paramesotriton (no rank).
/// NCBI TaxId: 2632613
/// </summary>
public abstract class unclassified_Paramesotriton : Paramesotriton, Iunclassified_Paramesotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paramesotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632613;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paramesotriton";
}
