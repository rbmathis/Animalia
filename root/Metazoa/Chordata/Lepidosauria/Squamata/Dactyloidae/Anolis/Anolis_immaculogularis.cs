namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis immaculogularis
/// NCBI TaxId: 1633558
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_immaculogularis : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis immaculogularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_immaculogularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1633558;
}
