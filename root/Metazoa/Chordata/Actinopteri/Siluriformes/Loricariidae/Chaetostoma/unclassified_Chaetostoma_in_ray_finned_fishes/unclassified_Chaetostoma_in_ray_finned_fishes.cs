using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Chaetostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Chaetostoma.unclassified_Chaetostoma_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Chaetostoma (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688337
/// </summary>
public abstract class unclassified_Chaetostoma_in_ray_finned_fishes : Chaetostoma, Iunclassified_Chaetostoma_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaetostoma (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688337;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaetostoma_in_ray_finned_fishes";
}
