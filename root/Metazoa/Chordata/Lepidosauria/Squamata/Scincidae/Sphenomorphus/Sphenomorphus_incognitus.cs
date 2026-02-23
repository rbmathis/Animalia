namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

/// <summary>
/// Species: Sphenomorphus incognitus
/// NCBI TaxId: 889765
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenomorphus_incognitus : Sphenomorphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenomorphus incognitus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenomorphus_incognitus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 889765;
}
