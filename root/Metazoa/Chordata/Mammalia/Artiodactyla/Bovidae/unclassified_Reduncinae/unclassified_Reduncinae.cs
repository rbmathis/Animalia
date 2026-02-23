using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.unclassified_Reduncinae;

/// <summary>
/// Abstract class for unclassified Reduncinae (no rank).
/// NCBI TaxId: 2966652
/// </summary>
public abstract class unclassified_Reduncinae : Bovidae, Iunclassified_Reduncinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Reduncinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2966652;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Reduncinae";
}
