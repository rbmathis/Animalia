namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus;

/// <summary>
/// Species: Miniopterus ambohitrensis
/// NCBI TaxId: 1574122
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Miniopterus_ambohitrensis : Miniopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Miniopterus ambohitrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Miniopterus_ambohitrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1574122;
}
