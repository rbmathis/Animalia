using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chilomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chilomys.unclassified_Chilomys;

/// <summary>
/// Abstract class for unclassified Chilomys (no rank).
/// NCBI TaxId: 2927130
/// </summary>
public abstract class unclassified_Chilomys : Chilomys, Iunclassified_Chilomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chilomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927130;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chilomys";
}
