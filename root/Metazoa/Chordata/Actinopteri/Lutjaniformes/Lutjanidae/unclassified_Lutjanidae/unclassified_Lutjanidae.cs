using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.unclassified_Lutjanidae;

/// <summary>
/// Abstract class for unclassified Lutjanidae (no rank).
/// NCBI TaxId: 1182229
/// </summary>
public abstract class unclassified_Lutjanidae : Lutjanidae, Iunclassified_Lutjanidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lutjanidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182229;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lutjanidae";
}
