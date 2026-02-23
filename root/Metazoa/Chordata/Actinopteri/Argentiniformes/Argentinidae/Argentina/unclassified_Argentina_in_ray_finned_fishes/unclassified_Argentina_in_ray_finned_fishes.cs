using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Argentina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Argentina.unclassified_Argentina_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Argentina (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2676985
/// </summary>
public abstract class unclassified_Argentina_in_ray_finned_fishes : Argentina, Iunclassified_Argentina_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argentina (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676985;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argentina_in_ray_finned_fishes";
}
