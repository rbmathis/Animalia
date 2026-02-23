namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Helodermatidae.Heloderma;

/// <summary>
/// Species: Heloderma horridum
/// NCBI TaxId: 8551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heloderma_horridum : Heloderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heloderma horridum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heloderma_horridum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8551;
}
