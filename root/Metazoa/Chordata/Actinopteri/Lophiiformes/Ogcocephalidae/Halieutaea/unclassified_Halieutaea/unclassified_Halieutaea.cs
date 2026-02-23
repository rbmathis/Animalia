using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halieutaea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halieutaea.unclassified_Halieutaea;

/// <summary>
/// Abstract class for unclassified Halieutaea (no rank).
/// NCBI TaxId: 2645745
/// </summary>
public abstract class unclassified_Halieutaea : Halieutaea, Iunclassified_Halieutaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halieutaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645745;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halieutaea";
}
