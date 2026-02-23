namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rhinemys;

/// <summary>
/// Species: Rhinemys rufipes
/// NCBI TaxId: 904229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinemys_rufipes : Rhinemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinemys rufipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinemys_rufipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904229;
}
