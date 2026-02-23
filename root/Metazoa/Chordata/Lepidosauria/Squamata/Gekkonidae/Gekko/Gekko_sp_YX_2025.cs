namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko sp. YX-2025
/// NCBI TaxId: 3469261
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_sp_YX_2025 : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko sp. YX-2025";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_sp_YX_2025";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3469261;
}
