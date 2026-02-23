namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. P96.9.18
/// NCBI TaxId: 330614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_P96918 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. P96.9.18";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_P96918";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 330614;
}
