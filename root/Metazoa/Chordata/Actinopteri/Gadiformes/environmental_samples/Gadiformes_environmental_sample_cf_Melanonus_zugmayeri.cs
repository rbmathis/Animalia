namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.environmental_samples;

/// <summary>
/// Species: Gadiformes environmental sample cf. Melanonus zugmayeri
/// NCBI TaxId: 1986941
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gadiformes_environmental_sample_cf_Melanonus_zugmayeri : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gadiformes environmental sample cf. Melanonus zugmayeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gadiformes_environmental_sample_cf_Melanonus_zugmayeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986941;
}
