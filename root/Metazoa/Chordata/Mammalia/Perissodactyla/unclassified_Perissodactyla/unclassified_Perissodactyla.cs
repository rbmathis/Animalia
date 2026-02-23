using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.unclassified_Perissodactyla;

/// <summary>
/// Abstract class for unclassified Perissodactyla (no rank).
/// NCBI TaxId: 1068251
/// </summary>
public abstract class unclassified_Perissodactyla : Perissodactyla, Iunclassified_Perissodactyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Perissodactyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1068251;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Perissodactyla";
}
