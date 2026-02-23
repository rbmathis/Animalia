namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus;

/// <summary>
/// Species: Elephantulus sp. karoensis
/// NCBI TaxId: 403081
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elephantulus_sp_karoensis : Elephantulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elephantulus sp. karoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elephantulus_sp_karoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 403081;
}
