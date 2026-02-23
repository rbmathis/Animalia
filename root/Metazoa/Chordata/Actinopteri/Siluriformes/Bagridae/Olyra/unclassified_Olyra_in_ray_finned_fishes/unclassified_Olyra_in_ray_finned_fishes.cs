using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Olyra;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Olyra.unclassified_Olyra_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Olyra (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688746
/// </summary>
public abstract class unclassified_Olyra_in_ray_finned_fishes : Olyra, Iunclassified_Olyra_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Olyra (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688746;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Olyra_in_ray_finned_fishes";
}
