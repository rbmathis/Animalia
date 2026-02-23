namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Species: Pelomedusa subrufa
/// NCBI TaxId: 44522
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomedusa_subrufa : Pelomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomedusa subrufa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomedusa_subrufa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44522;
}
