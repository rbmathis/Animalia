namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Marisora;

/// <summary>
/// Species: Marisora unimarginata
/// NCBI TaxId: 155309
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marisora_unimarginata : Marisora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marisora unimarginata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marisora_unimarginata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 155309;
}
