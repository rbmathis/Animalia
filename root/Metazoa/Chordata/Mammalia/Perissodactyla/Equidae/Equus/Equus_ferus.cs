namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus ferus
/// NCBI TaxId: 1114792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_ferus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus ferus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_ferus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1114792;
}
