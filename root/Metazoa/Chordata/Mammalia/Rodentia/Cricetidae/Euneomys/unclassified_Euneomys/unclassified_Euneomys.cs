using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euneomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euneomys.unclassified_Euneomys;

/// <summary>
/// Abstract class for unclassified Euneomys (no rank).
/// NCBI TaxId: 2627036
/// </summary>
public abstract class unclassified_Euneomys : Euneomys, Iunclassified_Euneomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euneomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627036;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euneomys";
}
