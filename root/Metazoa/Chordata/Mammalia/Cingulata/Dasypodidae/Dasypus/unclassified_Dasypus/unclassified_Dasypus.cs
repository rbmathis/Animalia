using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus.unclassified_Dasypus;

/// <summary>
/// Abstract class for unclassified Dasypus (no rank).
/// NCBI TaxId: 2641874
/// </summary>
public abstract class unclassified_Dasypus : Dasypus, Iunclassified_Dasypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641874;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasypus";
}
