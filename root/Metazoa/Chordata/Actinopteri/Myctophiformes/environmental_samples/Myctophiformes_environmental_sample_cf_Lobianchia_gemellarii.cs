namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.environmental_samples;

/// <summary>
/// Species: Myctophiformes environmental sample cf. Lobianchia gemellarii
/// NCBI TaxId: 1986934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myctophiformes_environmental_sample_cf_Lobianchia_gemellarii : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myctophiformes environmental sample cf. Lobianchia gemellarii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myctophiformes_environmental_sample_cf_Lobianchia_gemellarii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986934;
}
