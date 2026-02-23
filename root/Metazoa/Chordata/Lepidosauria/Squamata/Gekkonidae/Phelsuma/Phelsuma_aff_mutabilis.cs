namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma;

/// <summary>
/// Species: Phelsuma aff. mutabilis
/// NCBI TaxId: 634447
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phelsuma_aff_mutabilis : Phelsuma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phelsuma aff. mutabilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phelsuma_aff_mutabilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 634447;
}
