namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera aspis
/// NCBI TaxId: 8706
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_aspis : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera aspis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_aspis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8706;
}
