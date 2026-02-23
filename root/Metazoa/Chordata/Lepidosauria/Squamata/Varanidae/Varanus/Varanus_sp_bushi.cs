namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus sp. bushi
/// NCBI TaxId: 389467
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_sp_bushi : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus sp. bushi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_sp_bushi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 389467;
}
