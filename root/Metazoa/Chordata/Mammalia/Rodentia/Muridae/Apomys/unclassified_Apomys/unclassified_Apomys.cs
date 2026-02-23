using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys.unclassified_Apomys;

/// <summary>
/// Abstract class for unclassified Apomys (no rank).
/// NCBI TaxId: 2638486
/// </summary>
public abstract class unclassified_Apomys : Apomys, Iunclassified_Apomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638486;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apomys";
}
