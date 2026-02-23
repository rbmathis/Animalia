namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Macrovipera;

/// <summary>
/// Species: Macrovipera lebetinus
/// NCBI TaxId: 3148341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrovipera_lebetinus : Macrovipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrovipera lebetinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrovipera_lebetinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148341;
}
