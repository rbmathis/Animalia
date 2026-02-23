namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Choerophryne;

/// <summary>
/// Species: Choerophryne sp.
/// NCBI TaxId: 3345248
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Choerophryne_sp : Choerophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Choerophryne sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Choerophryne_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345248;
}
