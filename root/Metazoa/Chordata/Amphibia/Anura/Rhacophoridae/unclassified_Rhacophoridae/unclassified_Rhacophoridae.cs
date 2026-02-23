using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.unclassified_Rhacophoridae;

/// <summary>
/// Abstract class for unclassified Rhacophoridae (no rank).
/// NCBI TaxId: 2777175
/// </summary>
public abstract class unclassified_Rhacophoridae : Rhacophoridae, Iunclassified_Rhacophoridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhacophoridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2777175;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhacophoridae";
}
