using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys.unclassified_Hydromys;

/// <summary>
/// Abstract class for unclassified Hydromys (no rank).
/// NCBI TaxId: 3148843
/// </summary>
public abstract class unclassified_Hydromys : Hydromys, Iunclassified_Hydromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148843;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydromys";
}
