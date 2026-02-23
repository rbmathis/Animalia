using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Psychrophrynella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Psychrophrynella.unclassified_Psychrophrynella;

/// <summary>
/// Abstract class for unclassified Psychrophrynella (no rank).
/// NCBI TaxId: 2624870
/// </summary>
public abstract class unclassified_Psychrophrynella : Psychrophrynella, Iunclassified_Psychrophrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psychrophrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624870;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psychrophrynella";
}
