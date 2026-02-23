using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicydium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicydium.unclassified_Sicydium_in_ray_finned_fishes;

/// <summary>
/// Abstract class for unclassified Sicydium (in: ray-finned fishes) (no rank).
/// NCBI TaxId: 2651100
/// </summary>
public abstract class unclassified_Sicydium_in_ray_finned_fishes : Sicydium, Iunclassified_Sicydium_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicydium (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651100;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicydium_in_ray_finned_fishes";
}
