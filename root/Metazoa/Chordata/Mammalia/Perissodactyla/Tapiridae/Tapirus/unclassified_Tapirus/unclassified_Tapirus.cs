using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus.unclassified_Tapirus;

/// <summary>
/// Abstract class for unclassified Tapirus (no rank).
/// NCBI TaxId: 2634265
/// </summary>
public abstract class unclassified_Tapirus : Tapirus, Iunclassified_Tapirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tapirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634265;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tapirus";
}
