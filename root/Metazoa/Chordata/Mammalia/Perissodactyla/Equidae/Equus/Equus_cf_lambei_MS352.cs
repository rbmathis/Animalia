namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus cf. lambei MS352
/// NCBI TaxId: 1703867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_cf_lambei_MS352 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus cf. lambei MS352";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_cf_lambei_MS352";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1703867;
}
