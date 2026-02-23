namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Amphiglossus;

/// <summary>
/// Species: Amphiglossus reticulatus
/// NCBI TaxId: 249446
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiglossus_reticulatus : Amphiglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiglossus reticulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiglossus_reticulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 249446;
}
