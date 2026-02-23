namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Egernia;

/// <summary>
/// Species: Egernia epsisolus
/// NCBI TaxId: 1005989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Egernia_epsisolus : Egernia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Egernia epsisolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Egernia_epsisolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1005989;
}
