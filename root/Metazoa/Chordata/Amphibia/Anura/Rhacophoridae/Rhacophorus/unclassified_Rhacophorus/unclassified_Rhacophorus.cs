using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Rhacophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Rhacophorus.unclassified_Rhacophorus;

/// <summary>
/// Abstract class for unclassified Rhacophorus (no rank).
/// NCBI TaxId: 2624516
/// </summary>
public abstract class unclassified_Rhacophorus : Rhacophorus, Iunclassified_Rhacophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhacophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624516;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhacophorus";
}
