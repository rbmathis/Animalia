namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus;

/// <summary>
/// Species: Polypterus sp. IMCB-2001
/// NCBI TaxId: 172545
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polypterus_sp_IMCB_2001 : Polypterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polypterus sp. IMCB-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polypterus_sp_IMCB_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172545;
}
