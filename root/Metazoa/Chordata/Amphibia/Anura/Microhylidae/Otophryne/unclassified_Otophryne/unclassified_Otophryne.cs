using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Otophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Otophryne.unclassified_Otophryne;

/// <summary>
/// Abstract class for unclassified Otophryne (no rank).
/// NCBI TaxId: 2785344
/// </summary>
public abstract class unclassified_Otophryne : Otophryne, Iunclassified_Otophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2785344;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otophryne";
}
