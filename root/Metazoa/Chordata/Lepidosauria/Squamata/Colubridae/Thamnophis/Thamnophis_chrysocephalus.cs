namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis;

/// <summary>
/// Species: Thamnophis chrysocephalus
/// NCBI TaxId: 173360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thamnophis_chrysocephalus : Thamnophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thamnophis chrysocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thamnophis_chrysocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 173360;
}
