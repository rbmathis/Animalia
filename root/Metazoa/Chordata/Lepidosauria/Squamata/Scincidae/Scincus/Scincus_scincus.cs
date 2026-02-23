namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincus;

/// <summary>
/// Species: Scincus scincus
/// NCBI TaxId: 155317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scincus_scincus : Scincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scincus scincus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scincus_scincus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 155317;
}
