using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys.unclassified_Rhabdomys;

/// <summary>
/// Abstract class for unclassified Rhabdomys (no rank).
/// NCBI TaxId: 2819596
/// </summary>
public abstract class unclassified_Rhabdomys : Rhabdomys, Iunclassified_Rhabdomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819596;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdomys";
}
