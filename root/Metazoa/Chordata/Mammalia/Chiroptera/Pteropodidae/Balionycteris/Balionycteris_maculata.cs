namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Balionycteris;

/// <summary>
/// Species: Balionycteris maculata
/// NCBI TaxId: 77229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balionycteris_maculata : Balionycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balionycteris maculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balionycteris_maculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 77229;
}
