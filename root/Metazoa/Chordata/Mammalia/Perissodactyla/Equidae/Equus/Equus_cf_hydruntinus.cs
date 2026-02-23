namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus cf. hydruntinus
/// NCBI TaxId: 379505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_cf_hydruntinus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus cf. hydruntinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_cf_hydruntinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 379505;
}
