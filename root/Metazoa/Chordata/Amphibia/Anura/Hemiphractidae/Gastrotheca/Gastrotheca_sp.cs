namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Species: Gastrotheca sp.
/// NCBI TaxId: 1914539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gastrotheca_sp : Gastrotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gastrotheca sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gastrotheca_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1914539;
}
