using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Parotocinclus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Parotocinclus.unclassified_Parotocinclus;

/// <summary>
/// Abstract class for unclassified Parotocinclus (no rank).
/// NCBI TaxId: 2642514
/// </summary>
public abstract class unclassified_Parotocinclus : Parotocinclus, Iunclassified_Parotocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parotocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642514;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parotocinclus";
}
