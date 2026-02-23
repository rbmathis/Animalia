using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Zhangixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Zhangixalus.unclassified_Zhangixalus;

/// <summary>
/// Abstract class for unclassified Zhangixalus (no rank).
/// NCBI TaxId: 2733001
/// </summary>
public abstract class unclassified_Zhangixalus : Zhangixalus, Iunclassified_Zhangixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zhangixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2733001;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zhangixalus";
}
