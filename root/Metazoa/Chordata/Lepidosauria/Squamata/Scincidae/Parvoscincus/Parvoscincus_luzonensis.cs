namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Parvoscincus;

/// <summary>
/// Species: Parvoscincus luzonensis
/// NCBI TaxId: 999665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parvoscincus_luzonensis : Parvoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parvoscincus luzonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parvoscincus_luzonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 999665;
}
