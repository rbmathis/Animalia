using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Anomaloglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Anomaloglossus.unclassified_Anomaloglossus;

/// <summary>
/// Abstract class for unclassified Anomaloglossus (no rank).
/// NCBI TaxId: 2627410
/// </summary>
public abstract class unclassified_Anomaloglossus : Anomaloglossus, Iunclassified_Anomaloglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anomaloglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anomaloglossus";
}
