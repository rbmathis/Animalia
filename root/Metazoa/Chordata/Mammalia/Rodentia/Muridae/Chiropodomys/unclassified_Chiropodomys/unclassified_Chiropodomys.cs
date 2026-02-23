using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiropodomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiropodomys.unclassified_Chiropodomys;

/// <summary>
/// Abstract class for unclassified Chiropodomys (no rank).
/// NCBI TaxId: 2649636
/// </summary>
public abstract class unclassified_Chiropodomys : Chiropodomys, Iunclassified_Chiropodomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiropodomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiropodomys";
}
