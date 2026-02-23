namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps;

/// <summary>
/// Species: Breviceps acutirostris
/// NCBI TaxId: 2304174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Breviceps_acutirostris : Breviceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Breviceps acutirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Breviceps_acutirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2304174;
}
