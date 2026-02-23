using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys.unclassified_Aethomys;

/// <summary>
/// Abstract class for unclassified Aethomys (no rank).
/// NCBI TaxId: 2649651
/// </summary>
public abstract class unclassified_Aethomys : Aethomys, Iunclassified_Aethomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aethomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649651;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aethomys";
}
