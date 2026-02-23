using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Calamus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Calamus.unclassified_Calamus_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Calamus (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688304
/// </summary>
public abstract class unclassified_Calamus_in_ray_finned_fishes : Calamus, Iunclassified_Calamus_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calamus (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calamus_in_ray_finned_fishes";
}
