namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chilomys;

/// <summary>
/// Species: Chilomys sp. w NT-2025
/// NCBI TaxId: 2927134
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chilomys_sp_w_NT_2025 : Chilomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chilomys sp. w NT-2025";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chilomys_sp_w_NT_2025";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2927134;
}
