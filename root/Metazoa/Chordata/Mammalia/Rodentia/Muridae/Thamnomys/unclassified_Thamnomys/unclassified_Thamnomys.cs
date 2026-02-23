using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thamnomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thamnomys.unclassified_Thamnomys;

/// <summary>
/// Abstract class for unclassified Thamnomys (no rank).
/// NCBI TaxId: 2633349
/// </summary>
public abstract class unclassified_Thamnomys : Thamnomys, Iunclassified_Thamnomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thamnomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633349;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thamnomys";
}
