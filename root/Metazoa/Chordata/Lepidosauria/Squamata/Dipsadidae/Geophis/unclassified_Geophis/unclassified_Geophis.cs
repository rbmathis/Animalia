using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Geophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Geophis.unclassified_Geophis;

/// <summary>
/// Abstract class for unclassified Geophis (no rank).
/// NCBI TaxId: 2636438
/// </summary>
public abstract class unclassified_Geophis : Geophis, Iunclassified_Geophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geophis";
}
