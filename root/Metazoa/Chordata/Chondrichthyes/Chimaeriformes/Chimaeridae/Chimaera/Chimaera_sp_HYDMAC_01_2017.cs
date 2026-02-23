namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Species: Chimaera sp. HYDMAC-01-2017
/// NCBI TaxId: 2690199
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chimaera_sp_HYDMAC_01_2017 : Chimaera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chimaera sp. HYDMAC-01-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chimaera_sp_HYDMAC_01_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2690199;
}
