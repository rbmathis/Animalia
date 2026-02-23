namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko sp. wenxianensis
/// NCBI TaxId: 516000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_sp_wenxianensis : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko sp. wenxianensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_sp_wenxianensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 516000;
}
