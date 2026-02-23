using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae.Indirana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae.Indirana.unclassified_Indirana;

/// <summary>
/// Abstract class for unclassified Indirana (no rank).
/// NCBI TaxId: 2631376
/// </summary>
public abstract class unclassified_Indirana : Indirana, Iunclassified_Indirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631376;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indirana";
}
