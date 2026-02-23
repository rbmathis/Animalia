using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Feylinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Feylinia.unclassified_Feylinia;

/// <summary>
/// Abstract class for unclassified Feylinia (no rank).
/// NCBI TaxId: 2631220
/// </summary>
public abstract class unclassified_Feylinia : Feylinia, Iunclassified_Feylinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Feylinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631220;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Feylinia";
}
