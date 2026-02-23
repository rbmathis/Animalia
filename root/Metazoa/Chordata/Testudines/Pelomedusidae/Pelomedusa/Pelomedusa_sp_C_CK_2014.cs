namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Species: Pelomedusa sp. C CK-2014
/// NCBI TaxId: 1532883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomedusa_sp_C_CK_2014 : Pelomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomedusa sp. C CK-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomedusa_sp_C_CK_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1532883;
}
