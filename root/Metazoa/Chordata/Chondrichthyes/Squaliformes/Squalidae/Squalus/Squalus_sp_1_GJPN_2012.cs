namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus sp. 1 GJPN-2012
/// NCBI TaxId: 1214754
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_sp_1_GJPN_2012 : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus sp. 1 GJPN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_sp_1_GJPN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1214754;
}
