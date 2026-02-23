using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Gastrophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Gastrophryne.unclassified_Gastrophryne;

/// <summary>
/// Abstract class for unclassified Gastrophryne (no rank).
/// NCBI TaxId: 2617838
/// </summary>
public abstract class unclassified_Gastrophryne : Gastrophryne, Iunclassified_Gastrophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gastrophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gastrophryne";
}
