namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus vampyrus
/// NCBI TaxId: 132908
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_vampyrus : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus vampyrus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_vampyrus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 132908;
}
