namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Coccyzus;

/// <summary>
/// Species: Coccyzus longirostris
/// NCBI TaxId: 3054296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coccyzus_longirostris : Coccyzus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coccyzus longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coccyzus_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3054296;
}
