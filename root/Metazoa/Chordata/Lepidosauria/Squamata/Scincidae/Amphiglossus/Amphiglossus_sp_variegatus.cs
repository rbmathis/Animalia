namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Amphiglossus;

/// <summary>
/// Species: Amphiglossus sp. variegatus
/// NCBI TaxId: 1926514
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiglossus_sp_variegatus : Amphiglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiglossus sp. variegatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiglossus_sp_variegatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1926514;
}
