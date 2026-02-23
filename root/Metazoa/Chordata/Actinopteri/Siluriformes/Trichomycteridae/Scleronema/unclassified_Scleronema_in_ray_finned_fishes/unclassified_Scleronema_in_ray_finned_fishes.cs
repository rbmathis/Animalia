using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Scleronema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Scleronema.unclassified_Scleronema_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Scleronema (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688922
/// </summary>
public abstract class unclassified_Scleronema_in_ray_finned_fishes : Scleronema, Iunclassified_Scleronema_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scleronema (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688922;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scleronema_in_ray_finned_fishes";
}
