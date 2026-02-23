namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus ornatus
/// NCBI TaxId: 170227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_ornatus : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus ornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_ornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170227;
}
