using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.unclassified_Odocoileinae;

/// <summary>
/// Abstract class for unclassified Odocoileinae (no rank).
/// NCBI TaxId: 3112188
/// </summary>
public abstract class unclassified_Odocoileinae : Cervidae, Iunclassified_Odocoileinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odocoileinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3112188;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odocoileinae";
}
