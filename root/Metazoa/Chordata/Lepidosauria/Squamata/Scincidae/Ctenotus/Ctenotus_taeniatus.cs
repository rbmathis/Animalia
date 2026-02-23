namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ctenotus;

/// <summary>
/// Species: Ctenotus taeniatus
/// NCBI TaxId: 1470283
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenotus_taeniatus : Ctenotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenotus taeniatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenotus_taeniatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1470283;
}
