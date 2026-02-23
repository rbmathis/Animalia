using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae.Rondeletia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae.Rondeletia.unclassified_Rondeletia_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Rondeletia (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2688894
/// </summary>
public abstract class unclassified_Rondeletia_in_ray_finned_fishes : Rondeletia, Iunclassified_Rondeletia_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rondeletia (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rondeletia_in_ray_finned_fishes";
}
