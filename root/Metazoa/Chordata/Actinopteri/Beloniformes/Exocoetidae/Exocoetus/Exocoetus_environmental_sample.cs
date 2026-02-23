namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Exocoetus;

/// <summary>
/// Species: Exocoetus environmental sample
/// NCBI TaxId: 1366073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Exocoetus_environmental_sample : Exocoetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Exocoetus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Exocoetus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1366073;
}
