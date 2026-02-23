namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scotinomys;

/// <summary>
/// Species: Scotinomys xerampelinus
/// NCBI TaxId: 89107
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scotinomys_xerampelinus : Scotinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scotinomys xerampelinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scotinomys_xerampelinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89107;
}
