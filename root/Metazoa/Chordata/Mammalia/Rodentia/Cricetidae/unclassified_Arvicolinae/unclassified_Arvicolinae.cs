using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.unclassified_Arvicolinae;

/// <summary>
/// Abstract class for unclassified Arvicolinae (no rank).
/// NCBI TaxId: 2929748
/// </summary>
public abstract class unclassified_Arvicolinae : Cricetidae, Iunclassified_Arvicolinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arvicolinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2929748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arvicolinae";
}
