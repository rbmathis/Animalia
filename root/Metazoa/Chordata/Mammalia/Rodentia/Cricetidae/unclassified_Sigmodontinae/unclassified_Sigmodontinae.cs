using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.unclassified_Sigmodontinae;

/// <summary>
/// Abstract class for unclassified Sigmodontinae (no rank).
/// NCBI TaxId: 1158967
/// </summary>
public abstract class unclassified_Sigmodontinae : Cricetidae, Iunclassified_Sigmodontinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sigmodontinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158967;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sigmodontinae";
}
