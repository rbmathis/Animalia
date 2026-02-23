using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lasiancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lasiancistrus.unclassified_Lasiancistrus;

/// <summary>
/// Abstract class for unclassified Lasiancistrus (no rank).
/// NCBI TaxId: 2630104
/// </summary>
public abstract class unclassified_Lasiancistrus : Lasiancistrus, Iunclassified_Lasiancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lasiancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630104;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lasiancistrus";
}
