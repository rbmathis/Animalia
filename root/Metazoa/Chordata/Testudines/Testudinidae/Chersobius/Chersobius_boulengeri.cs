namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersobius;

/// <summary>
/// Species: Chersobius boulengeri
/// NCBI TaxId: 285997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chersobius_boulengeri : Chersobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chersobius boulengeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chersobius_boulengeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 285997;
}
