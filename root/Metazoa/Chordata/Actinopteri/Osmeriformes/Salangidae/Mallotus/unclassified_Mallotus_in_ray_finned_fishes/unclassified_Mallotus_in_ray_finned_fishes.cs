using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Mallotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Mallotus.unclassified_Mallotus_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Mallotus (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688670
/// </summary>
public abstract class unclassified_Mallotus_in_ray_finned_fishes : Mallotus, Iunclassified_Mallotus_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mallotus (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mallotus_in_ray_finned_fishes";
}
