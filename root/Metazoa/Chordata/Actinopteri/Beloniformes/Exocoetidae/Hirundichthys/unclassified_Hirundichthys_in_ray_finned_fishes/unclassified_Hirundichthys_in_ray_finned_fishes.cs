using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys.unclassified_Hirundichthys_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Hirundichthys (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3406964
/// </summary>
public abstract class unclassified_Hirundichthys_in_ray_finned_fishes : Hirundichthys, Iunclassified_Hirundichthys_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hirundichthys (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hirundichthys_in_ray_finned_fishes";
}
