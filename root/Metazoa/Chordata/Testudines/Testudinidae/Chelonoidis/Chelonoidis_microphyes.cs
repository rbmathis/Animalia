namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Species: Chelonoidis microphyes
/// NCBI TaxId: 2039269
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonoidis_microphyes : Chelonoidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonoidis microphyes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonoidis_microphyes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2039269;
}
