namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Artibeus;

/// <summary>
/// Species: Artibeus cf. obscurus
/// NCBI TaxId: 410850
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artibeus_cf_obscurus : Artibeus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artibeus cf. obscurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artibeus_cf_obscurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 410850;
}
