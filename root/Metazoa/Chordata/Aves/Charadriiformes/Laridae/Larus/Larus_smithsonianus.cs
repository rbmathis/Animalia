namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus smithsonianus
/// NCBI TaxId: 243888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_smithsonianus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus smithsonianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_smithsonianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 243888;
}
