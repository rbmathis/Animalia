using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Phyzelaphryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Phyzelaphryne.unclassified_Phyzelaphryne;

/// <summary>
/// Abstract class for unclassified Phyzelaphryne (no rank).
/// NCBI TaxId: 2643355
/// </summary>
public abstract class unclassified_Phyzelaphryne : Phyzelaphryne, Iunclassified_Phyzelaphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyzelaphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643355;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyzelaphryne";
}
