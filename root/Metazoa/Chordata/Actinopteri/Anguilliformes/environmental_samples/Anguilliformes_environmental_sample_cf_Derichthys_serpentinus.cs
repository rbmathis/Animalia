namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.environmental_samples;

/// <summary>
/// Species: Anguilliformes environmental sample cf. Derichthys serpentinus
/// NCBI TaxId: 1986921
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilliformes_environmental_sample_cf_Derichthys_serpentinus : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilliformes environmental sample cf. Derichthys serpentinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilliformes_environmental_sample_cf_Derichthys_serpentinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986921;
}
