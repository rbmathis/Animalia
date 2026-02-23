using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Indosylvirana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Indosylvirana.unclassified_Indosylvirana;

/// <summary>
/// Abstract class for unclassified Indosylvirana (no rank).
/// NCBI TaxId: 2822327
/// </summary>
public abstract class unclassified_Indosylvirana : Indosylvirana, Iunclassified_Indosylvirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indosylvirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2822327;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indosylvirana";
}
