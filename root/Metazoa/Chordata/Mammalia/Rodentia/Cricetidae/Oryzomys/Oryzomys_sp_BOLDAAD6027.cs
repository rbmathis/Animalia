namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

/// <summary>
/// Species: Oryzomys sp. BOLD:AAD6027
/// NCBI TaxId: 1003888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryzomys_sp_BOLDAAD6027 : Oryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryzomys sp. BOLD:AAD6027";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryzomys_sp_BOLDAAD6027";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003888;
}
