using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Sladenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Sladenia.unclassified_Sladenia_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Sladenia (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2677891
/// </summary>
public abstract class unclassified_Sladenia_in_ray_finned_fishes : Sladenia, Iunclassified_Sladenia_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sladenia (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sladenia_in_ray_finned_fishes";
}
