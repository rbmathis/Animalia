namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincus;

/// <summary>
/// Species: Scincus albifasciatus
/// NCBI TaxId: 500830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scincus_albifasciatus : Scincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scincus albifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scincus_albifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 500830;
}
