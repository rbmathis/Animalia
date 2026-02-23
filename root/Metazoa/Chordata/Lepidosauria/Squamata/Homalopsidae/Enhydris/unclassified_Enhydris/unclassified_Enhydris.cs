using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Enhydris;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Enhydris.unclassified_Enhydris;

/// <summary>
/// Abstract class for unclassified Enhydris (no rank).
/// NCBI TaxId: 2620086
/// </summary>
public abstract class unclassified_Enhydris : Enhydris, Iunclassified_Enhydris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enhydris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620086;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enhydris";
}
