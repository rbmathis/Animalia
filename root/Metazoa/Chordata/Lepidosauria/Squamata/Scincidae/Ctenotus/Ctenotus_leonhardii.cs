namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ctenotus;

/// <summary>
/// Species: Ctenotus leonhardii
/// NCBI TaxId: 220776
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenotus_leonhardii : Ctenotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenotus leonhardii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenotus_leonhardii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 220776;
}
