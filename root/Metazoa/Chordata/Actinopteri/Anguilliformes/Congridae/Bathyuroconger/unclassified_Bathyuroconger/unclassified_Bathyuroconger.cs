using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathyuroconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathyuroconger.unclassified_Bathyuroconger;

/// <summary>
/// Abstract class for unclassified Bathyuroconger (no rank).
/// NCBI TaxId: 2623454
/// </summary>
public abstract class unclassified_Bathyuroconger : Bathyuroconger, Iunclassified_Bathyuroconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyuroconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyuroconger";
}
