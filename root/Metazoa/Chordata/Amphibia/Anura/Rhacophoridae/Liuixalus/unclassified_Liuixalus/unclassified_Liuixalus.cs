using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Liuixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Liuixalus.unclassified_Liuixalus;

/// <summary>
/// Abstract class for unclassified Liuixalus (no rank).
/// NCBI TaxId: 2631119
/// </summary>
public abstract class unclassified_Liuixalus : Liuixalus, Iunclassified_Liuixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liuixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liuixalus";
}
