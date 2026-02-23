namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Leptomantis;

/// <summary>
/// Species: Leptomantis angulirostris
/// NCBI TaxId: 143541
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptomantis_angulirostris : Leptomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptomantis angulirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptomantis_angulirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143541;
}
