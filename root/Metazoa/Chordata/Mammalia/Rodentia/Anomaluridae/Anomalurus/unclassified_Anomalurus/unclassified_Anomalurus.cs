using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Anomalurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Anomalurus.unclassified_Anomalurus;

/// <summary>
/// Abstract class for unclassified Anomalurus (no rank).
/// NCBI TaxId: 2623273
/// </summary>
public abstract class unclassified_Anomalurus : Anomalurus, Iunclassified_Anomalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anomalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623273;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anomalurus";
}
