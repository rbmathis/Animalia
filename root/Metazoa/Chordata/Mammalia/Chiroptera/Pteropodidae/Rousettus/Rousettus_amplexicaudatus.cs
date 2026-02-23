namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Rousettus;

/// <summary>
/// Species: Rousettus amplexicaudatus
/// NCBI TaxId: 58083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rousettus_amplexicaudatus : Rousettus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rousettus amplexicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rousettus_amplexicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58083;
}
