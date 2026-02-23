namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

/// <summary>
/// Species: Triakis sp. IMCB-2001
/// NCBI TaxId: 172657
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triakis_sp_IMCB_2001 : Triakis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triakis sp. IMCB-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triakis_sp_IMCB_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172657;
}
