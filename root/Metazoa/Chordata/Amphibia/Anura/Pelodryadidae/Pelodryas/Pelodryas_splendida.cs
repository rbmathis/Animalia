namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Pelodryas;

/// <summary>
/// Species: Pelodryas splendida
/// NCBI TaxId: 30345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodryas_splendida : Pelodryas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodryas splendida";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodryas_splendida";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30345;
}
