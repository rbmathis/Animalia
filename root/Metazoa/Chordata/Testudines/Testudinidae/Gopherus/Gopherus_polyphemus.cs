namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Gopherus;

/// <summary>
/// Species: Gopherus polyphemus
/// NCBI TaxId: 38773
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gopherus_polyphemus : Gopherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gopherus polyphemus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gopherus_polyphemus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38773;
}
