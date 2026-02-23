namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.environmental_samples;

/// <summary>
/// Species: Stomiiformes environmental sample cf. Gonostoma denudatum
/// NCBI TaxId: 1986929
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stomiiformes_environmental_sample_cf_Gonostoma_denudatum : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stomiiformes environmental sample cf. Gonostoma denudatum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stomiiformes_environmental_sample_cf_Gonostoma_denudatum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986929;
}
