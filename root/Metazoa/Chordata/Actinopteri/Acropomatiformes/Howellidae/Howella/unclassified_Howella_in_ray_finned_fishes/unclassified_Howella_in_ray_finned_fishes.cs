using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.Howella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.Howella.unclassified_Howella_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Howella (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2631645
/// </summary>
public abstract class unclassified_Howella_in_ray_finned_fishes : Howella, Iunclassified_Howella_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Howella (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631645;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Howella_in_ray_finned_fishes";
}
