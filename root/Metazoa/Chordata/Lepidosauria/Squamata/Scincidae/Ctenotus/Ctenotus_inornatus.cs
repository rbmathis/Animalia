namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ctenotus;

/// <summary>
/// Species: Ctenotus inornatus
/// NCBI TaxId: 245600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenotus_inornatus : Ctenotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenotus inornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenotus_inornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245600;
}
