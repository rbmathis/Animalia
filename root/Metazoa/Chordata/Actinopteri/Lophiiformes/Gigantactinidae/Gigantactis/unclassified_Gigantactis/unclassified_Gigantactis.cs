using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Gigantactis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Gigantactis.unclassified_Gigantactis;

/// <summary>
/// Abstract class for unclassified Gigantactis (no rank).
/// NCBI TaxId: 2685428
/// </summary>
public abstract class unclassified_Gigantactis : Gigantactis, Iunclassified_Gigantactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gigantactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685428;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gigantactis";
}
