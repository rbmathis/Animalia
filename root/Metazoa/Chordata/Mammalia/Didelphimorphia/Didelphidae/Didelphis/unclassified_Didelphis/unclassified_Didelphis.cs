using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis.unclassified_Didelphis;

/// <summary>
/// Abstract class for unclassified Didelphis (no rank).
/// NCBI TaxId: 2645117
/// </summary>
public abstract class unclassified_Didelphis : Didelphis, Iunclassified_Didelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Didelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645117;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Didelphis";
}
