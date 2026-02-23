using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricaria.unclassified_Loricaria_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Loricaria (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688652
/// </summary>
public abstract class unclassified_Loricaria_in_ray_finned_fishes : Loricaria, Iunclassified_Loricaria_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Loricaria (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688652;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Loricaria_in_ray_finned_fishes";
}
