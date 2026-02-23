namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

/// <summary>
/// Species: Bubo virginianus
/// NCBI TaxId: 56268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubo_virginianus : Bubo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubo virginianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubo_virginianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56268;
}
