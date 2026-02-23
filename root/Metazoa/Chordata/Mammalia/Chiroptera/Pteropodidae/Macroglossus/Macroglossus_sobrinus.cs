namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Macroglossus;

/// <summary>
/// Species: Macroglossus sobrinus
/// NCBI TaxId: 326083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macroglossus_sobrinus : Macroglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macroglossus sobrinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macroglossus_sobrinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 326083;
}
