namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra sibirica
/// NCBI TaxId: 72544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_sibirica : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra sibirica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_sibirica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 72544;
}
