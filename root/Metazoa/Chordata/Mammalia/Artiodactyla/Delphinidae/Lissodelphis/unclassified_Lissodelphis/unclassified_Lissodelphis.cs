using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Lissodelphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Lissodelphis.unclassified_Lissodelphis;

/// <summary>
/// Abstract class for unclassified Lissodelphis (no rank).
/// NCBI TaxId: 2617658
/// </summary>
public abstract class unclassified_Lissodelphis : Lissodelphis, Iunclassified_Lissodelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lissodelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617658;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lissodelphis";
}
