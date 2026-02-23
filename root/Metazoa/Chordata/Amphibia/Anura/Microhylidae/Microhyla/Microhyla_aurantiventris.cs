namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla aurantiventris
/// NCBI TaxId: 2744373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_aurantiventris : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla aurantiventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_aurantiventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2744373;
}
