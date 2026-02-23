namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Simiscincus;

/// <summary>
/// Species: Simiscincus aurantiacus
/// NCBI TaxId: 394174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Simiscincus_aurantiacus : Simiscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Simiscincus aurantiacus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Simiscincus_aurantiacus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 394174;
}
