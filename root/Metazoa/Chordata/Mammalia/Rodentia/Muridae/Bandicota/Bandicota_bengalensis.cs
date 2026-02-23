namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota;

/// <summary>
/// Species: Bandicota bengalensis
/// NCBI TaxId: 69079
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bandicota_bengalensis : Bandicota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bandicota bengalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bandicota_bengalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69079;
}
