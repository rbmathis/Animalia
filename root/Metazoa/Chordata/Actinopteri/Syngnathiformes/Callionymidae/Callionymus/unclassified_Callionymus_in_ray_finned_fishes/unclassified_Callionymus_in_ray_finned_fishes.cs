using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus.unclassified_Callionymus_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Callionymus (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3406877
/// </summary>
public abstract class unclassified_Callionymus_in_ray_finned_fishes : Callionymus, Iunclassified_Callionymus_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callionymus (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406877;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callionymus_in_ray_finned_fishes";
}
