namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Hippotragus;

/// <summary>
/// Species: Hippotragus leucophaeus
/// NCBI TaxId: 37185
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippotragus_leucophaeus : Hippotragus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippotragus leucophaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippotragus_leucophaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37185;
}
