using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euryoryzomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euryoryzomys.unclassified_Euryoryzomys;

/// <summary>
/// Abstract class for unclassified Euryoryzomys (no rank).
/// NCBI TaxId: 2621306
/// </summary>
public abstract class unclassified_Euryoryzomys : Euryoryzomys, Iunclassified_Euryoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euryoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621306;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euryoryzomys";
}
