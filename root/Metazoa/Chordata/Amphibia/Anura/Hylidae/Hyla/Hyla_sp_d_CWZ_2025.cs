namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla sp. d CWZ-2025
/// NCBI TaxId: 3399643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_sp_d_CWZ_2025 : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla sp. d CWZ-2025";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_sp_d_CWZ_2025";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3399643;
}
