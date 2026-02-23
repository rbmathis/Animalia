using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Fukomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Fukomys.unclassified_Fukomys;

/// <summary>
/// Abstract class for unclassified Fukomys (no rank).
/// NCBI TaxId: 2644920
/// </summary>
public abstract class unclassified_Fukomys : Fukomys, Iunclassified_Fukomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fukomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fukomys";
}
