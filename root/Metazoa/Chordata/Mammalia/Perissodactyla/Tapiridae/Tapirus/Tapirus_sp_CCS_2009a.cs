namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Species: Tapirus sp. CCS-2009a
/// NCBI TaxId: 638934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tapirus_sp_CCS_2009a : Tapirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tapirus sp. CCS-2009a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tapirus_sp_CCS_2009a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 638934;
}
