namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Neogale;

/// <summary>
/// Species: Neogale environmental sample
/// NCBI TaxId: 1002249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neogale_environmental_sample : Neogale
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neogale environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neogale_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002249;
}
