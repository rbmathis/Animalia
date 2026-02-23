using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parachela;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parachela.unclassified_Parachela_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Parachela (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3158388
/// </summary>
public abstract class unclassified_Parachela_in_ray_finned_fishes : Parachela, Iunclassified_Parachela_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parachela (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3158388;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parachela_in_ray_finned_fishes";
}
