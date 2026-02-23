using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys.unclassified_Maxomys;

/// <summary>
/// Abstract class for unclassified Maxomys (no rank).
/// NCBI TaxId: 1003856
/// </summary>
public abstract class unclassified_Maxomys : Maxomys, Iunclassified_Maxomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maxomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003856;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maxomys";
}
