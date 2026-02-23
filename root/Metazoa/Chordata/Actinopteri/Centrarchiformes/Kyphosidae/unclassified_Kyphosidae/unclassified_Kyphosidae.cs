using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.unclassified_Kyphosidae;

/// <summary>
/// Abstract class for unclassified Kyphosidae (no rank).
/// NCBI TaxId: 3040166
/// </summary>
public abstract class unclassified_Kyphosidae : Kyphosidae, Iunclassified_Kyphosidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kyphosidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040166;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kyphosidae";
}
