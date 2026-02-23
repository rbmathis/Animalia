using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne.unclassified_Paedophryne;

/// <summary>
/// Abstract class for unclassified Paedophryne (no rank).
/// NCBI TaxId: 2862810
/// </summary>
public abstract class unclassified_Paedophryne : Paedophryne, Iunclassified_Paedophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paedophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2862810;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paedophryne";
}
