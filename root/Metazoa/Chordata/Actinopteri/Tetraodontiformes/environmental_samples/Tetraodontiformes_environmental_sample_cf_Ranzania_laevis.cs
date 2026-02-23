namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.environmental_samples;

/// <summary>
/// Species: Tetraodontiformes environmental sample cf. Ranzania laevis
/// NCBI TaxId: 1986946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tetraodontiformes_environmental_sample_cf_Ranzania_laevis : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tetraodontiformes environmental sample cf. Ranzania laevis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tetraodontiformes_environmental_sample_cf_Ranzania_laevis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986946;
}
