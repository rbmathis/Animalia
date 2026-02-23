namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus dominicanus
/// NCBI TaxId: 37036
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_dominicanus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus dominicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_dominicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37036;
}
