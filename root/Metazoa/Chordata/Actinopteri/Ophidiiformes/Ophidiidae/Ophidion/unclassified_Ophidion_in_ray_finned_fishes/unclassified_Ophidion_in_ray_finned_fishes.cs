using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Ophidion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Ophidion.unclassified_Ophidion_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Ophidion (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688752
/// </summary>
public abstract class unclassified_Ophidion_in_ray_finned_fishes : Ophidion, Iunclassified_Ophidion_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophidion (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688752;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophidion_in_ray_finned_fishes";
}
