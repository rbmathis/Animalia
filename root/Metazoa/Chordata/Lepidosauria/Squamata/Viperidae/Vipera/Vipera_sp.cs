namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera sp.
/// NCBI TaxId: 3674659
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_sp : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3674659;
}
