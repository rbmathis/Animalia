namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys sp. t TD-2025
/// NCBI TaxId: 3440905
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_sp_t_TD_2025 : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys sp. t TD-2025";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_sp_t_TD_2025";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3440905;
}
