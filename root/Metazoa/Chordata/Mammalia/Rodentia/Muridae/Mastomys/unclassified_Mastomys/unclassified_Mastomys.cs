using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys.unclassified_Mastomys;

/// <summary>
/// Abstract class for unclassified Mastomys (no rank).
/// NCBI TaxId: 2637779
/// </summary>
public abstract class unclassified_Mastomys : Mastomys, Iunclassified_Mastomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mastomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mastomys";
}
