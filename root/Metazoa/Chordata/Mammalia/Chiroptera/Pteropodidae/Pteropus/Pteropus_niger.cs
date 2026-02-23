namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus niger
/// NCBI TaxId: 170225
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_niger : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170225;
}
