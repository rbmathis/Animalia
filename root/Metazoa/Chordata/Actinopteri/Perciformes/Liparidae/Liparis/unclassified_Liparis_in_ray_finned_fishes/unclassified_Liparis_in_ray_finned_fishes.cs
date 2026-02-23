using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Liparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Liparis.unclassified_Liparis_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Liparis (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2609094
/// </summary>
public abstract class unclassified_Liparis_in_ray_finned_fishes : Liparis, Iunclassified_Liparis_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liparis (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609094;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liparis_in_ray_finned_fishes";
}
