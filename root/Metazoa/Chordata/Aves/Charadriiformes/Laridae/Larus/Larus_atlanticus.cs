namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus atlanticus
/// NCBI TaxId: 328042
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_atlanticus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus atlanticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_atlanticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 328042;
}
