namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Species: Pelomedusa barbata
/// NCBI TaxId: 1488664
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomedusa_barbata : Pelomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomedusa barbata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomedusa_barbata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1488664;
}
