namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.environmental_samples;

/// <summary>
/// Species: Myctophiformes environmental sample cf. Ceratoscopelus sp.
/// NCBI TaxId: 1986911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myctophiformes_environmental_sample_cf_Ceratoscopelus_sp : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myctophiformes environmental sample cf. Ceratoscopelus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myctophiformes_environmental_sample_cf_Ceratoscopelus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986911;
}
