using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Scobinancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Scobinancistrus.unclassified_Scobinancistrus;

/// <summary>
/// Abstract class for unclassified Scobinancistrus (no rank).
/// NCBI TaxId: 2646693
/// </summary>
public abstract class unclassified_Scobinancistrus : Scobinancistrus, Iunclassified_Scobinancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scobinancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646693;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scobinancistrus";
}
