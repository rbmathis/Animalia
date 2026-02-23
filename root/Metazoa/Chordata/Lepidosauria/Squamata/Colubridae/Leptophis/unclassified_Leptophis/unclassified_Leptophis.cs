using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Leptophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Leptophis.unclassified_Leptophis;

/// <summary>
/// Abstract class for unclassified Leptophis (no rank).
/// NCBI TaxId: 2930363
/// </summary>
public abstract class unclassified_Leptophis : Leptophis, Iunclassified_Leptophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2930363;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptophis";
}
