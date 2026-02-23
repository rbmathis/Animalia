namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus mongolicus
/// NCBI TaxId: 119967
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_mongolicus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus mongolicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_mongolicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119967;
}
