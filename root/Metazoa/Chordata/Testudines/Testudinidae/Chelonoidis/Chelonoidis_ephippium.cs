namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Species: Chelonoidis ephippium
/// NCBI TaxId: 2804498
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonoidis_ephippium : Chelonoidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonoidis ephippium";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonoidis_ephippium";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804498;
}
