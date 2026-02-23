using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Mannophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Mannophryne.unclassified_Mannophryne;

/// <summary>
/// Abstract class for unclassified Mannophryne (no rank).
/// NCBI TaxId: 2685381
/// </summary>
public abstract class unclassified_Mannophryne : Mannophryne, Iunclassified_Mannophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mannophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685381;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mannophryne";
}
