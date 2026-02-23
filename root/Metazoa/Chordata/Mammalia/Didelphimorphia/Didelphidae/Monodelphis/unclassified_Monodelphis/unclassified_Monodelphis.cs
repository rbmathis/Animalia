using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Monodelphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Monodelphis.unclassified_Monodelphis;

/// <summary>
/// Abstract class for unclassified Monodelphis (no rank).
/// NCBI TaxId: 2623451
/// </summary>
public abstract class unclassified_Monodelphis : Monodelphis, Iunclassified_Monodelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monodelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monodelphis";
}
