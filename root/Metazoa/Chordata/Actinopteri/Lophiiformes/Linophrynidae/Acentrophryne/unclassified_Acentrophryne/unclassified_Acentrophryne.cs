using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Acentrophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Acentrophryne.unclassified_Acentrophryne;

/// <summary>
/// Abstract class for unclassified Acentrophryne (no rank).
/// NCBI TaxId: 3140545
/// </summary>
public abstract class unclassified_Acentrophryne : Acentrophryne, Iunclassified_Acentrophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acentrophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3140545;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acentrophryne";
}
