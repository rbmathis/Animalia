using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lemniscomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lemniscomys.unclassified_Lemniscomys;

/// <summary>
/// Abstract class for unclassified Lemniscomys (no rank).
/// NCBI TaxId: 2618422
/// </summary>
public abstract class unclassified_Lemniscomys : Lemniscomys, Iunclassified_Lemniscomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lemniscomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618422;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lemniscomys";
}
