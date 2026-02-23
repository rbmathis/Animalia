using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Tridens;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Tridens.unclassified_Tridens_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Tridens (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2689020
/// </summary>
public abstract class unclassified_Tridens_in_ray_finned_fishes : Tridens, Iunclassified_Tridens_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tridens (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689020;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tridens_in_ray_finned_fishes";
}
