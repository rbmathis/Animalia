using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Trichiurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Trichiurus.unclassified_Trichiurus;

/// <summary>
/// Abstract class for unclassified Trichiurus (no rank).
/// NCBI TaxId: 2619136
/// </summary>
public abstract class unclassified_Trichiurus : Trichiurus, Iunclassified_Trichiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichiurus";
}
