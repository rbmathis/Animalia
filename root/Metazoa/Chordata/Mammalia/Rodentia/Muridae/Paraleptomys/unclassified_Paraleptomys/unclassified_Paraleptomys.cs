using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paraleptomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paraleptomys.unclassified_Paraleptomys;

/// <summary>
/// Abstract class for unclassified Paraleptomys (no rank).
/// NCBI TaxId: 2627855
/// </summary>
public abstract class unclassified_Paraleptomys : Paraleptomys, Iunclassified_Paraleptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraleptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraleptomys";
}
