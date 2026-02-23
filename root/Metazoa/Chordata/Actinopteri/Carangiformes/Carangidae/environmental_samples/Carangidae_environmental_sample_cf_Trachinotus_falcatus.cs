namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.environmental_samples;

/// <summary>
/// Species: Carangidae environmental sample cf. Trachinotus falcatus
/// NCBI TaxId: 2592849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carangidae_environmental_sample_cf_Trachinotus_falcatus : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carangidae environmental sample cf. Trachinotus falcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carangidae_environmental_sample_cf_Trachinotus_falcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2592849;
}
