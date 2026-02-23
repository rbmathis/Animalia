namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Species: Pelomedusa galeata
/// NCBI TaxId: 1488665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomedusa_galeata : Pelomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomedusa galeata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomedusa_galeata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1488665;
}
