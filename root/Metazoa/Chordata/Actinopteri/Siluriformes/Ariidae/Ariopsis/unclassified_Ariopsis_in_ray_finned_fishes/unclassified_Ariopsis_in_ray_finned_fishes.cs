using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ariopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ariopsis.unclassified_Ariopsis_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Ariopsis (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688262
/// </summary>
public abstract class unclassified_Ariopsis_in_ray_finned_fishes : Ariopsis, Iunclassified_Ariopsis_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ariopsis (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688262;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ariopsis_in_ray_finned_fishes";
}
