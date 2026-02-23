using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Melanophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Melanophryne.unclassified_Melanophryne;

/// <summary>
/// Abstract class for unclassified Melanophryne (no rank).
/// NCBI TaxId: 2645688
/// </summary>
public abstract class unclassified_Melanophryne : Melanophryne, Iunclassified_Melanophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645688;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanophryne";
}
