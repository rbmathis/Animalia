namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.environmental_samples;

/// <summary>
/// Species: Thunnus environmental sample
/// NCBI TaxId: 2002828
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thunnus_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thunnus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thunnus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2002828;
}
