namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacella;

/// <summary>
/// Species: Psittacella brehmii
/// NCBI TaxId: 458123
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacella_brehmii : Psittacella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacella brehmii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacella_brehmii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458123;
}
