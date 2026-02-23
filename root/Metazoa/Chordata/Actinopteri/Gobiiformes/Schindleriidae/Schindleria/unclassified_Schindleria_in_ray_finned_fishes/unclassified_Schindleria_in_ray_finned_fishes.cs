using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae.Schindleria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae.Schindleria.unclassified_Schindleria_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Schindleria (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688913
/// </summary>
public abstract class unclassified_Schindleria_in_ray_finned_fishes : Schindleria, Iunclassified_Schindleria_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schindleria (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688913;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schindleria_in_ray_finned_fishes";
}
