using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oreoryzomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oreoryzomys.unclassified_Oreoryzomys;

/// <summary>
/// Abstract class for unclassified Oreoryzomys (no rank).
/// NCBI TaxId: 3451654
/// </summary>
public abstract class unclassified_Oreoryzomys : Oreoryzomys, Iunclassified_Oreoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3451654;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreoryzomys";
}
