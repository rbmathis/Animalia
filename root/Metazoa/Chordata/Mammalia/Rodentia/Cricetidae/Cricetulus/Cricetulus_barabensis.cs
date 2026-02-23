namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus;

/// <summary>
/// Species: Cricetulus barabensis
/// NCBI TaxId: 329629
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetulus_barabensis : Cricetulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetulus barabensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetulus_barabensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329629;
}
