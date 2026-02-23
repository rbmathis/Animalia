namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

/// <summary>
/// Species: Ara tricolor
/// NCBI TaxId: 2049294
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ara_tricolor : Ara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ara tricolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ara_tricolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2049294;
}
