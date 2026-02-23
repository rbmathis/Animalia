using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Anomalops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Anomalops.unclassified_Anomalops;

/// <summary>
/// Abstract class for unclassified Anomalops (no rank).
/// NCBI TaxId: 2625539
/// </summary>
public abstract class unclassified_Anomalops : Anomalops, Iunclassified_Anomalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anomalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625539;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anomalops";
}
