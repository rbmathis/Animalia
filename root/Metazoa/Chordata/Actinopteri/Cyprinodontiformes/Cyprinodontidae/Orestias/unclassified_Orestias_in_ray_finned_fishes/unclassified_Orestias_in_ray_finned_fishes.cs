using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Orestias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Orestias.unclassified_Orestias_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Orestias (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688755
/// </summary>
public abstract class unclassified_Orestias_in_ray_finned_fishes : Orestias, Iunclassified_Orestias_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orestias (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688755;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orestias_in_ray_finned_fishes";
}
