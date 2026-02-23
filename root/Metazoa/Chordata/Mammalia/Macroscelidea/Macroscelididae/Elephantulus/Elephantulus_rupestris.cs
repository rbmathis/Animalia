namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus;

/// <summary>
/// Species: Elephantulus rupestris
/// NCBI TaxId: 113278
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elephantulus_rupestris : Elephantulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elephantulus rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elephantulus_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 113278;
}
