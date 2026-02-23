namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera shemakhensis
/// NCBI TaxId: 2493205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_shemakhensis : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera shemakhensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_shemakhensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2493205;
}
