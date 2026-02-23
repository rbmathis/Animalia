namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus aldabrensis
/// NCBI TaxId: 589507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_aldabrensis : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus aldabrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_aldabrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 589507;
}
