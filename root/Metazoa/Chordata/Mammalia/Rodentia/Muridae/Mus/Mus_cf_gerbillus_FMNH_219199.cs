namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus cf. gerbillus FMNH 219199
/// NCBI TaxId: 2904042
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_cf_gerbillus_FMNH_219199 : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus cf. gerbillus FMNH 219199";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_cf_gerbillus_FMNH_219199";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2904042;
}
