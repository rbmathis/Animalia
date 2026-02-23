using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Heterixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Heterixalus.unclassified_Heterixalus;

/// <summary>
/// Abstract class for unclassified Heterixalus (no rank).
/// NCBI TaxId: 2649910
/// </summary>
public abstract class unclassified_Heterixalus : Heterixalus, Iunclassified_Heterixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649910;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterixalus";
}
