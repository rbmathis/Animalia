namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus armenicus
/// NCBI TaxId: 119635
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_armenicus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus armenicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_armenicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119635;
}
