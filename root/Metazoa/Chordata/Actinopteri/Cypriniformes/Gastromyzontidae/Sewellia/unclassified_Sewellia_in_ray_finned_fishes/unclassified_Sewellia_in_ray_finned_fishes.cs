using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Sewellia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Sewellia.unclassified_Sewellia_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Sewellia (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688936
/// </summary>
public abstract class unclassified_Sewellia_in_ray_finned_fishes : Sewellia, Iunclassified_Sewellia_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sewellia (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sewellia_in_ray_finned_fishes";
}
