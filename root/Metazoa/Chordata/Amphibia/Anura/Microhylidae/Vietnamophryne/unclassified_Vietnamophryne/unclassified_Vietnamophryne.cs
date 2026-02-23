using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Vietnamophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Vietnamophryne.unclassified_Vietnamophryne;

/// <summary>
/// Abstract class for unclassified Vietnamophryne (no rank).
/// NCBI TaxId: 2628117
/// </summary>
public abstract class unclassified_Vietnamophryne : Vietnamophryne, Iunclassified_Vietnamophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vietnamophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628117;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vietnamophryne";
}
