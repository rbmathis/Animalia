namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Chelydra;

/// <summary>
/// Species: Chelydra acutirostris
/// NCBI TaxId: 2804324
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelydra_acutirostris : Chelydra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelydra acutirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelydra_acutirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804324;
}
