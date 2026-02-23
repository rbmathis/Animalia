using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eothenomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eothenomys.unclassified_Eothenomys;

/// <summary>
/// Abstract class for unclassified Eothenomys (no rank).
/// NCBI TaxId: 2685018
/// </summary>
public abstract class unclassified_Eothenomys : Eothenomys, Iunclassified_Eothenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eothenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eothenomys";
}
