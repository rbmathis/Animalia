namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus pacificus
/// NCBI TaxId: 328040
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_pacificus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 328040;
}
