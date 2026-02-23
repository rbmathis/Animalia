namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

/// <summary>
/// Species: Lynx pardinus
/// NCBI TaxId: 191816
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynx_pardinus : Lynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynx pardinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynx_pardinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191816;
}
