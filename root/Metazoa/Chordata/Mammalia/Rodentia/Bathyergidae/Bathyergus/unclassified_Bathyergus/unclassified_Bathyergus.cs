using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Bathyergus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Bathyergus.unclassified_Bathyergus;

/// <summary>
/// Abstract class for unclassified Bathyergus (no rank).
/// NCBI TaxId: 2642705
/// </summary>
public abstract class unclassified_Bathyergus : Bathyergus, Iunclassified_Bathyergus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyergus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642705;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyergus";
}
