namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. P98.6.8
/// NCBI TaxId: 330617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_P9868 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. P98.6.8";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_P9868";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 330617;
}
