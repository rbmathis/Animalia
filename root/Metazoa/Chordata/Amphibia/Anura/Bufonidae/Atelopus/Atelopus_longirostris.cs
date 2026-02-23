namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

/// <summary>
/// Species: Atelopus longirostris
/// NCBI TaxId: 164297
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atelopus_longirostris : Atelopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atelopus longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atelopus_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 164297;
}
