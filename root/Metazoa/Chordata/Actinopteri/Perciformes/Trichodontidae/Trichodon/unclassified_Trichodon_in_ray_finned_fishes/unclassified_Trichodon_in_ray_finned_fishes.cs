using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae.Trichodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae.Trichodon.unclassified_Trichodon_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Trichodon (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2677848
/// </summary>
public abstract class unclassified_Trichodon_in_ray_finned_fishes : Trichodon, Iunclassified_Trichodon_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichodon (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677848;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichodon_in_ray_finned_fishes";
}
