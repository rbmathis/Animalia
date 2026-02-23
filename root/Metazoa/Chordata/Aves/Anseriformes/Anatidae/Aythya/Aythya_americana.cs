namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aythya;

/// <summary>
/// Species: Aythya americana
/// NCBI TaxId: 30385
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aythya_americana : Aythya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aythya americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aythya_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30385;
}
