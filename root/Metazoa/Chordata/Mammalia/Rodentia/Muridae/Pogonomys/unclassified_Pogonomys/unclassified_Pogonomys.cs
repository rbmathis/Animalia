using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys.unclassified_Pogonomys;

/// <summary>
/// Abstract class for unclassified Pogonomys (no rank).
/// NCBI TaxId: 2620817
/// </summary>
public abstract class unclassified_Pogonomys : Pogonomys, Iunclassified_Pogonomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pogonomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pogonomys";
}
