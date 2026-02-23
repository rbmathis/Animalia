using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Beaufortia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Beaufortia.unclassified_Beaufortia_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Beaufortia (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688278
/// </summary>
public abstract class unclassified_Beaufortia_in_ray_finned_fishes : Beaufortia, Iunclassified_Beaufortia_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Beaufortia (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Beaufortia_in_ray_finned_fishes";
}
