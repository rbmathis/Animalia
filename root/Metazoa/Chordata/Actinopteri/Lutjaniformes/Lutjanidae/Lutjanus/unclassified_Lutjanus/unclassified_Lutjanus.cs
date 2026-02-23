using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Lutjanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Lutjanus.unclassified_Lutjanus;

/// <summary>
/// Abstract class for unclassified Lutjanus (no rank).
/// NCBI TaxId: 2619398
/// </summary>
public abstract class unclassified_Lutjanus : Lutjanus, Iunclassified_Lutjanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lutjanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lutjanus";
}
