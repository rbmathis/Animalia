namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Syncerus;

/// <summary>
/// Species: Syncerus environmental sample
/// NCBI TaxId: 2682738
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syncerus_environmental_sample : Syncerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syncerus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syncerus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2682738;
}
