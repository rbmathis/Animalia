using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wilfredomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wilfredomys.unclassified_Wilfredomys;

/// <summary>
/// Abstract class for unclassified Wilfredomys (no rank).
/// NCBI TaxId: 2627515
/// </summary>
public abstract class unclassified_Wilfredomys : Wilfredomys, Iunclassified_Wilfredomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Wilfredomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627515;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Wilfredomys";
}
