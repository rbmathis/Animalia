using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Monotaxis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Monotaxis.unclassified_Monotaxis_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Monotaxis (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688704
/// </summary>
public abstract class unclassified_Monotaxis_in_ray_finned_fishes : Monotaxis, Iunclassified_Monotaxis_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monotaxis (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688704;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monotaxis_in_ray_finned_fishes";
}
