namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Species: Tapirus sp. TTS-2004
/// NCBI TaxId: 261757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tapirus_sp_TTS_2004 : Tapirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tapirus sp. TTS-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tapirus_sp_TTS_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 261757;
}
