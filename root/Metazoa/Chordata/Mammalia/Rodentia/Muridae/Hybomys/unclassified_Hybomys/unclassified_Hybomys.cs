using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hybomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hybomys.unclassified_Hybomys;

/// <summary>
/// Abstract class for unclassified Hybomys (no rank).
/// NCBI TaxId: 2781601
/// </summary>
public abstract class unclassified_Hybomys : Hybomys, Iunclassified_Hybomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hybomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2781601;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hybomys";
}
