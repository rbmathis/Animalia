using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis.unclassified_Thamnophis;

/// <summary>
/// Abstract class for unclassified Thamnophis (no rank).
/// NCBI TaxId: 2641731
/// </summary>
public abstract class unclassified_Thamnophis : Thamnophis, Iunclassified_Thamnophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thamnophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thamnophis";
}
