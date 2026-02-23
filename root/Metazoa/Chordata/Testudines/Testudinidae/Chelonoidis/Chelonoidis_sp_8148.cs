namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Species: Chelonoidis sp. 8148
/// NCBI TaxId: 1129811
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonoidis_sp_8148 : Chelonoidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonoidis sp. 8148";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonoidis_sp_8148";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1129811;
}
