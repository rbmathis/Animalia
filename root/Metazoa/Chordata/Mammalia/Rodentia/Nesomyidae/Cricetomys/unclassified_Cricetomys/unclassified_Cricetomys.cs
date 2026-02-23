using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Cricetomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Cricetomys.unclassified_Cricetomys;

/// <summary>
/// Abstract class for unclassified Cricetomys (no rank).
/// NCBI TaxId: 2638341
/// </summary>
public abstract class unclassified_Cricetomys : Cricetomys, Iunclassified_Cricetomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cricetomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638341;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cricetomys";
}
