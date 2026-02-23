namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersobius;

/// <summary>
/// Species: Chersobius signatus
/// NCBI TaxId: 285992
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chersobius_signatus : Chersobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chersobius signatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chersobius_signatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 285992;
}
