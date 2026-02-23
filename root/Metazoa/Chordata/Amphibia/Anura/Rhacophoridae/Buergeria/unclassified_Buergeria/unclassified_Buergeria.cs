using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Buergeria;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Buergeria.unclassified_Buergeria;

/// <summary>
/// Abstract class for unclassified Buergeria (no rank).
/// NCBI TaxId: 2648237
/// </summary>
public abstract class unclassified_Buergeria : Buergeria, Iunclassified_Buergeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Buergeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648237;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Buergeria";
}
