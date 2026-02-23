using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Idiacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Idiacanthus.unclassified_Idiacanthus_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Idiacanthus (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688579
/// </summary>
public abstract class unclassified_Idiacanthus_in_ray_finned_fishes : Idiacanthus, Iunclassified_Idiacanthus_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Idiacanthus (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Idiacanthus_in_ray_finned_fishes";
}
