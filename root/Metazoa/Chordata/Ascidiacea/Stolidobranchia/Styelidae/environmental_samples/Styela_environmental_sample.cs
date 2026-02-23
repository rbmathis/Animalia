namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.environmental_samples;

/// <summary>
/// Species: Styela environmental sample
/// NCBI TaxId: 2594308
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Styela_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Styela environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Styela_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2594308;
}
