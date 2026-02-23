using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes.Acanthocepola;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes.Acanthocepola.unclassified_Acanthocepola;

/// <summary>
/// Abstract class for unclassified Acanthocepola (no rank).
/// NCBI TaxId: 2639838
/// </summary>
public abstract class unclassified_Acanthocepola : Acanthocepola, Iunclassified_Acanthocepola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthocepola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthocepola";
}
