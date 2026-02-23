using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.unclassified_Equidae;

/// <summary>
/// Abstract class for unclassified Equidae (no rank).
/// NCBI TaxId: 2778395
/// </summary>
public abstract class unclassified_Equidae : Equidae, Iunclassified_Equidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Equidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2778395;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Equidae";
}
