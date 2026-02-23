namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.environmental_samples;

/// <summary>
/// Species: Aulopiformes environmental sample cf. Magnisudis atlantica
/// NCBI TaxId: 1986937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aulopiformes_environmental_sample_cf_Magnisudis_atlantica : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aulopiformes environmental sample cf. Magnisudis atlantica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aulopiformes_environmental_sample_cf_Magnisudis_atlantica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986937;
}
