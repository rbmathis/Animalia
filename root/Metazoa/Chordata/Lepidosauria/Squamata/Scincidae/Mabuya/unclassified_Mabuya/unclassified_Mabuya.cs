using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mabuya;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mabuya.unclassified_Mabuya;

/// <summary>
/// Abstract class for unclassified Mabuya (no rank).
/// NCBI TaxId: 2630350
/// </summary>
public abstract class unclassified_Mabuya : Mabuya, Iunclassified_Mabuya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mabuya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630350;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mabuya";
}
