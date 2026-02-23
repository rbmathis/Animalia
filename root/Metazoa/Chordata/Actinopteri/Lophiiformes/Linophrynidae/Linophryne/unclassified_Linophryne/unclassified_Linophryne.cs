using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Linophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Linophryne.unclassified_Linophryne;

/// <summary>
/// Abstract class for unclassified Linophryne (no rank).
/// NCBI TaxId: 2676829
/// </summary>
public abstract class unclassified_Linophryne : Linophryne, Iunclassified_Linophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Linophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676829;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Linophryne";
}
