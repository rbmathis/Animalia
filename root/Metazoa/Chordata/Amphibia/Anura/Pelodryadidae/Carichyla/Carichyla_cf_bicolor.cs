namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Carichyla;

/// <summary>
/// Species: Carichyla cf. bicolor
/// NCBI TaxId: 3681212
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carichyla_cf_bicolor : Carichyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carichyla cf. bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carichyla_cf_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681212;
}
