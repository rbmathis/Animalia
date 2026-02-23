namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Gopherus;

/// <summary>
/// Species: Gopherus evgoodei
/// NCBI TaxId: 1825980
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gopherus_evgoodei : Gopherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gopherus evgoodei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gopherus_evgoodei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1825980;
}
