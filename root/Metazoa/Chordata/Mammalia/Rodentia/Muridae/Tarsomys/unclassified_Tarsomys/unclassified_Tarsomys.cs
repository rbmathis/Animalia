using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tarsomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tarsomys.unclassified_Tarsomys;

/// <summary>
/// Abstract class for unclassified Tarsomys (no rank).
/// NCBI TaxId: 3002830
/// </summary>
public abstract class unclassified_Tarsomys : Tarsomys, Iunclassified_Tarsomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tarsomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3002830;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tarsomys";
}
