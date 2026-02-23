namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Charmosyna;

/// <summary>
/// Species: Charmosyna palmarum
/// NCBI TaxId: 2301368
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charmosyna_palmarum : Charmosyna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charmosyna palmarum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charmosyna_palmarum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2301368;
}
