namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Phacochoerus;

/// <summary>
/// Species: Phacochoerus africanus
/// NCBI TaxId: 41426
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phacochoerus_africanus : Phacochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phacochoerus africanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phacochoerus_africanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 41426;
}
