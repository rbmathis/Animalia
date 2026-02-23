using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Odocoileus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Odocoileus.unclassified_Odocoileus;

/// <summary>
/// Abstract class for unclassified Odocoileus (no rank).
/// NCBI TaxId: 2625720
/// </summary>
public abstract class unclassified_Odocoileus : Odocoileus, Iunclassified_Odocoileus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odocoileus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odocoileus";
}
