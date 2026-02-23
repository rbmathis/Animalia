using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Bryophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Bryophryne.unclassified_Bryophryne;

/// <summary>
/// Abstract class for unclassified Bryophryne (no rank).
/// NCBI TaxId: 2618432
/// </summary>
public abstract class unclassified_Bryophryne : Bryophryne, Iunclassified_Bryophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618432;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryophryne";
}
