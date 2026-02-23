using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhabdophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhabdophis.unclassified_Rhabdophis;

/// <summary>
/// Abstract class for unclassified Rhabdophis (no rank).
/// NCBI TaxId: 2624563
/// </summary>
public abstract class unclassified_Rhabdophis : Rhabdophis, Iunclassified_Rhabdophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624563;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdophis";
}
