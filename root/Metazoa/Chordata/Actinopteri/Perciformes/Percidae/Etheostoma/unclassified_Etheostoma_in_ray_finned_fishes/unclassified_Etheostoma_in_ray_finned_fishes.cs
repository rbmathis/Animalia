using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Etheostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Etheostoma.unclassified_Etheostoma_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Etheostoma (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 3406929
/// </summary>
public abstract class unclassified_Etheostoma_in_ray_finned_fishes : Etheostoma, Iunclassified_Etheostoma_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Etheostoma (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Etheostoma_in_ray_finned_fishes";
}
