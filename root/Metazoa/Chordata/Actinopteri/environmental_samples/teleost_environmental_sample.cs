namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.environmental_samples;

/// <summary>
/// Species: teleost environmental sample
/// NCBI TaxId: 282529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class teleost_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "teleost environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "teleost_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 282529;
}
