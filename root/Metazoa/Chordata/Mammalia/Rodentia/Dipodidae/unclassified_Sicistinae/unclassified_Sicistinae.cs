using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.unclassified_Sicistinae;

/// <summary>
/// Abstract class for unclassified Sicistinae (no rank).
/// NCBI TaxId: 3409898
/// </summary>
public abstract class unclassified_Sicistinae : Dipodidae, Iunclassified_Sicistinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicistinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3409898;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicistinae";
}
