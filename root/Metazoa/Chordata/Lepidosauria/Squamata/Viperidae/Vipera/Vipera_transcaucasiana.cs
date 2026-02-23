namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera transcaucasiana
/// NCBI TaxId: 235552
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_transcaucasiana : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera transcaucasiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_transcaucasiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235552;
}
