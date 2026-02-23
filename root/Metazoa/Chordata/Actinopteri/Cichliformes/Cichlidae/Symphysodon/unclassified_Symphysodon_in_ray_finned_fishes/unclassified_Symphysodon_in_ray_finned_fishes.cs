using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Symphysodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Symphysodon.unclassified_Symphysodon_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Symphysodon (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688977
/// </summary>
public abstract class unclassified_Symphysodon_in_ray_finned_fishes : Symphysodon, Iunclassified_Symphysodon_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symphysodon (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688977;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symphysodon_in_ray_finned_fishes";
}
