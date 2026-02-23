using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Coris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Coris.unclassified_Coris_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Coris (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2677135
/// </summary>
public abstract class unclassified_Coris_in_ray_finned_fishes : Coris, Iunclassified_Coris_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coris (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677135;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coris_in_ray_finned_fishes";
}
