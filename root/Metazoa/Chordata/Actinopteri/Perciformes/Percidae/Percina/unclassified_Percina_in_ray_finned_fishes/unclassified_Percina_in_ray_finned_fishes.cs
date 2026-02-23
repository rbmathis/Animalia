using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percina.unclassified_Percina_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Percina (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3407059
/// </summary>
public abstract class unclassified_Percina_in_ray_finned_fishes : Percina, Iunclassified_Percina_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Percina (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407059;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Percina_in_ray_finned_fishes";
}
