namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

/// <summary>
/// Species: Sphenomorphus multisquamatus
/// NCBI TaxId: 999654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenomorphus_multisquamatus : Sphenomorphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenomorphus multisquamatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenomorphus_multisquamatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 999654;
}
