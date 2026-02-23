namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

/// <summary>
/// Species: Didelphis virginiana
/// NCBI TaxId: 9267
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Didelphis_virginiana : Didelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Didelphis virginiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Didelphis_virginiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9267;
}
