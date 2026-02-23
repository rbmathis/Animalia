namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemisotidae.Hemisus;

/// <summary>
/// Species: Hemisus marmoratus
/// NCBI TaxId: 83971
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemisus_marmoratus : Hemisus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemisus marmoratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemisus_marmoratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 83971;
}
