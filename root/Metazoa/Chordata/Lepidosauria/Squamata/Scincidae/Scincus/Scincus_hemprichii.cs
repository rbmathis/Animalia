namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincus;

/// <summary>
/// Species: Scincus hemprichii
/// NCBI TaxId: 500829
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scincus_hemprichii : Scincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scincus hemprichii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scincus_hemprichii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 500829;
}
