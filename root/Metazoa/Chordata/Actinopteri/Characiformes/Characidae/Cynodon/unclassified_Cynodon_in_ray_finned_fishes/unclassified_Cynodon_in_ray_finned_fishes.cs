using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cynodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cynodon.unclassified_Cynodon_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Cynodon (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688389
/// </summary>
public abstract class unclassified_Cynodon_in_ray_finned_fishes : Cynodon, Iunclassified_Cynodon_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynodon (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688389;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynodon_in_ray_finned_fishes";
}
