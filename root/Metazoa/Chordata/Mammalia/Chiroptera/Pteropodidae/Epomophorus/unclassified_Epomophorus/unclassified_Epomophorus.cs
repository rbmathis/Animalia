using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomophorus.unclassified_Epomophorus;

/// <summary>
/// Abstract class for unclassified Epomophorus (no rank).
/// NCBI TaxId: 2625338
/// </summary>
public abstract class unclassified_Epomophorus : Epomophorus, Iunclassified_Epomophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epomophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625338;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epomophorus";
}
