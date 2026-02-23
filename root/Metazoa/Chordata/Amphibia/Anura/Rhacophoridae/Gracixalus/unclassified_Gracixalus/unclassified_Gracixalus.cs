using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Gracixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Gracixalus.unclassified_Gracixalus;

/// <summary>
/// Abstract class for unclassified Gracixalus (no rank).
/// NCBI TaxId: 2621105
/// </summary>
public abstract class unclassified_Gracixalus : Gracixalus, Iunclassified_Gracixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gracixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621105;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gracixalus";
}
