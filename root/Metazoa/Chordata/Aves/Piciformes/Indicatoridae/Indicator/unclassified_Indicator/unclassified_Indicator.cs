using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator.unclassified_Indicator;

/// <summary>
/// Abstract class for unclassified Indicator (no rank).
/// NCBI TaxId: 2634862
/// </summary>
public abstract class unclassified_Indicator : Indicator, Iunclassified_Indicator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indicator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indicator";
}
