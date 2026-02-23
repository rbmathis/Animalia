namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Ceratodontidae.Neoceratodus;

/// <summary>
/// Species: Neoceratodus forsteri
/// NCBI TaxId: 7892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neoceratodus_forsteri : Neoceratodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neoceratodus forsteri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neoceratodus_forsteri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7892;
}
