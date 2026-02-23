namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chilomys;

/// <summary>
/// Species: Chilomys sp. p NT-2024
/// NCBI TaxId: 2927133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chilomys_sp_p_NT_2024 : Chilomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chilomys sp. p NT-2024";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chilomys_sp_p_NT_2024";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2927133;
}
