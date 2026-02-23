namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ototylomys;

/// <summary>
/// Species: Ototylomys sp. TAGG-2014
/// NCBI TaxId: 1523245
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ototylomys_sp_TAGG_2014 : Ototylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ototylomys sp. TAGG-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ototylomys_sp_TAGG_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1523245;
}
