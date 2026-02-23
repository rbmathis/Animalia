using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Vandellia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Vandellia.unclassified_Vandellia_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Vandellia (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2630687
/// </summary>
public abstract class unclassified_Vandellia_in_ray_finned_fishes : Vandellia, Iunclassified_Vandellia_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vandellia (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630687;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vandellia_in_ray_finned_fishes";
}
