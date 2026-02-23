using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Kyphosus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Kyphosus.unclassified_Kyphosus;

/// <summary>
/// Abstract class for unclassified Kyphosus (no rank).
/// NCBI TaxId: 2636159
/// </summary>
public abstract class unclassified_Kyphosus : Kyphosus, Iunclassified_Kyphosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kyphosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kyphosus";
}
