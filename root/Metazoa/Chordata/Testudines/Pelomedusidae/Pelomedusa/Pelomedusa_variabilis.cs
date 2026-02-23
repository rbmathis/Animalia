namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Species: Pelomedusa variabilis
/// NCBI TaxId: 1510147
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomedusa_variabilis : Pelomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomedusa variabilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomedusa_variabilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1510147;
}
