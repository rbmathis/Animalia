using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Kali;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Kali.unclassified_Kali_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Kali (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2677441
/// </summary>
public abstract class unclassified_Kali_in_ray_finned_fishes : Kali, Iunclassified_Kali_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kali (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677441;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kali_in_ray_finned_fishes";
}
