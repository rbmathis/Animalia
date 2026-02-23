using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Sphenophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Sphenophryne.unclassified_Sphenophryne;

/// <summary>
/// Abstract class for unclassified Sphenophryne (no rank).
/// NCBI TaxId: 2626296
/// </summary>
public abstract class unclassified_Sphenophryne : Sphenophryne, Iunclassified_Sphenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626296;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphenophryne";
}
