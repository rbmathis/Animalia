namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandra;

/// <summary>
/// Species: Salamandra longirostris
/// NCBI TaxId: 3372588
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandra_longirostris : Salamandra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandra longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandra_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3372588;
}
