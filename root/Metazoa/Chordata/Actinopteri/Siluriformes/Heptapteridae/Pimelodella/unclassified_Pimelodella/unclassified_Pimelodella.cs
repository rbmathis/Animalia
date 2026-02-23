using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pimelodella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pimelodella.unclassified_Pimelodella;

/// <summary>
/// Abstract class for unclassified Pimelodella (no rank).
/// NCBI TaxId: 2608183
/// </summary>
public abstract class unclassified_Pimelodella : Pimelodella, Iunclassified_Pimelodella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pimelodella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pimelodella";
}
