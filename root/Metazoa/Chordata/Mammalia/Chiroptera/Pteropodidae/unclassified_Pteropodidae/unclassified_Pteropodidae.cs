using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.unclassified_Pteropodidae;

/// <summary>
/// Abstract class for unclassified Pteropodidae (no rank).
/// NCBI TaxId: 3136031
/// </summary>
public abstract class unclassified_Pteropodidae : Pteropodidae, Iunclassified_Pteropodidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pteropodidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pteropodidae";
}
