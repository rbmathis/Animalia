namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis;

/// <summary>
/// Species: Thamnophis hammondii
/// NCBI TaxId: 173529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thamnophis_hammondii : Thamnophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thamnophis hammondii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thamnophis_hammondii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 173529;
}
