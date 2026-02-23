using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Hippidion;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Hippidion.unclassified_Hippidion;

/// <summary>
/// Abstract class for unclassified Hippidion (no rank).
/// NCBI TaxId: 330589
/// </summary>
public abstract class unclassified_Hippidion : Hippidion, Iunclassified_Hippidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hippidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hippidion";
}
