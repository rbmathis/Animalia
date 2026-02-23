using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Guyanancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Guyanancistrus.unclassified_Guyanancistrus;

/// <summary>
/// Abstract class for unclassified Guyanancistrus (no rank).
/// NCBI TaxId: 3101848
/// </summary>
public abstract class unclassified_Guyanancistrus : Guyanancistrus, Iunclassified_Guyanancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Guyanancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101848;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Guyanancistrus";
}
