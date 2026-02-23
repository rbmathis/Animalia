using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halicmetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halicmetus.unclassified_Halicmetus;

/// <summary>
/// Abstract class for unclassified Halicmetus (no rank).
/// NCBI TaxId: 3140549
/// </summary>
public abstract class unclassified_Halicmetus : Halicmetus, Iunclassified_Halicmetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halicmetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3140549;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halicmetus";
}
