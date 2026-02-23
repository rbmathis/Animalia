namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.environmental_samples;

/// <summary>
/// Species: Carangiformes environmental sample cf. Naucrates ductor
/// NCBI TaxId: 1986943
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carangiformes_environmental_sample_cf_Naucrates_ductor : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carangiformes environmental sample cf. Naucrates ductor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carangiformes_environmental_sample_cf_Naucrates_ductor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986943;
}
