namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko sp. A PLW-2019
/// NCBI TaxId: 2683604
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_sp_A_PLW_2019 : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko sp. A PLW-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_sp_A_PLW_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2683604;
}
