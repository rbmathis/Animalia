using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oreophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oreophryne.unclassified_Oreophryne;

/// <summary>
/// Abstract class for unclassified Oreophryne (no rank).
/// NCBI TaxId: 2609366
/// </summary>
public abstract class unclassified_Oreophryne : Oreophryne, Iunclassified_Oreophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreophryne";
}
