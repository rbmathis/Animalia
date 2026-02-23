namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla sp. USNM 575016
/// NCBI TaxId: 2593951
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_sp_USNM_575016 : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla sp. USNM 575016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_sp_USNM_575016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2593951;
}
