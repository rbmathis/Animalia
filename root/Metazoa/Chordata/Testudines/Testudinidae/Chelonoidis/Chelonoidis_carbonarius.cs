namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Species: Chelonoidis carbonarius
/// NCBI TaxId: 50047
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonoidis_carbonarius : Chelonoidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonoidis carbonarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonoidis_carbonarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50047;
}
