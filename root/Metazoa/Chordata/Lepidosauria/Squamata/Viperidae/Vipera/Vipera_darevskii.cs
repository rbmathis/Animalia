namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera darevskii
/// NCBI TaxId: 2493147
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_darevskii : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera darevskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_darevskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2493147;
}
