namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brasiliscincus;

/// <summary>
/// Species: Brasiliscincus agilis
/// NCBI TaxId: 185481
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brasiliscincus_agilis : Brasiliscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brasiliscincus agilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brasiliscincus_agilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 185481;
}
