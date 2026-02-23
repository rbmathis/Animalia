namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus;

/// <summary>
/// Species: Aerodramus brevirostris
/// NCBI TaxId: 46488
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aerodramus_brevirostris : Aerodramus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aerodramus brevirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aerodramus_brevirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46488;
}
