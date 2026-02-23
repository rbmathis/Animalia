namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. UW54705
/// NCBI TaxId: 2984905
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_UW54705 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. UW54705";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_UW54705";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2984905;
}
