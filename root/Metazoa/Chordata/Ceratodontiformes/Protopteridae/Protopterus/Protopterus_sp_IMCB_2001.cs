namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

/// <summary>
/// Species: Protopterus sp. IMCB-2001
/// NCBI TaxId: 172656
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Protopterus_sp_IMCB_2001 : Protopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Protopterus sp. IMCB-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Protopterus_sp_IMCB_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172656;
}
