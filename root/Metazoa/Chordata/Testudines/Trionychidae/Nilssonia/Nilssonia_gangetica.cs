namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Nilssonia;

/// <summary>
/// Species: Nilssonia gangetica
/// NCBI TaxId: 904210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nilssonia_gangetica : Nilssonia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nilssonia gangetica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nilssonia_gangetica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904210;
}
