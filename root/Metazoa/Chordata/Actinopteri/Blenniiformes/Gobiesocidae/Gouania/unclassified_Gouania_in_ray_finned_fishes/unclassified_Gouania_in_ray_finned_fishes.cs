using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gouania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gouania.unclassified_Gouania_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Gouania (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688525
/// </summary>
public abstract class unclassified_Gouania_in_ray_finned_fishes : Gouania, Iunclassified_Gouania_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gouania (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688525;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gouania_in_ray_finned_fishes";
}
