using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.unclassified_Pimelodidae;

/// <summary>
/// Abstract class for unclassified Pimelodidae (no rank).
/// NCBI TaxId: 1150210
/// </summary>
public abstract class unclassified_Pimelodidae : Pimelodidae, Iunclassified_Pimelodidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pimelodidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150210;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pimelodidae";
}
