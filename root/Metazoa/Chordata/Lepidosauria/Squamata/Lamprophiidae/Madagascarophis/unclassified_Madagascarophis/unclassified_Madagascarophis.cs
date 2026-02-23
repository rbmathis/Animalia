using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Madagascarophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Madagascarophis.unclassified_Madagascarophis;

/// <summary>
/// Abstract class for unclassified Madagascarophis (no rank).
/// NCBI TaxId: 2648116
/// </summary>
public abstract class unclassified_Madagascarophis : Madagascarophis, Iunclassified_Madagascarophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Madagascarophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648116;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Madagascarophis";
}
