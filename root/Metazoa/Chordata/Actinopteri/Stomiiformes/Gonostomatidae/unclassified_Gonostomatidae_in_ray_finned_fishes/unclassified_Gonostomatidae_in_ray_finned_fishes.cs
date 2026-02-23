using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.unclassified_Gonostomatidae_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Gonostomatidae (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3407299
/// </summary>
public abstract class unclassified_Gonostomatidae_in_ray_finned_fishes : Gonostomatidae, Iunclassified_Gonostomatidae_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gonostomatidae (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407299;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gonostomatidae_in_ray_finned_fishes";
}
