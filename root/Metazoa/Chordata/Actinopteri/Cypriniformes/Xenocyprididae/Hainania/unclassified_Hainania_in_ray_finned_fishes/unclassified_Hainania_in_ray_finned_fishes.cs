using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hainania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hainania.unclassified_Hainania_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Hainania (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3401561
/// </summary>
public abstract class unclassified_Hainania_in_ray_finned_fishes : Hainania, Iunclassified_Hainania_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hainania (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3401561;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hainania_in_ray_finned_fishes";
}
