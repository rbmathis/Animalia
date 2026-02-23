namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera anatolica
/// NCBI TaxId: 1296988
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_anatolica : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera anatolica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_anatolica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1296988;
}
