using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus.unclassified_Equus;

/// <summary>
/// Abstract class for unclassified Equus (no rank).
/// NCBI TaxId: 310262
/// </summary>
public abstract class unclassified_Equus : Equus, Iunclassified_Equus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Equus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310262;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Equus";
}
