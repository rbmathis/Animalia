namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Malayemys;

/// <summary>
/// Species: Malayemys khoratensis
/// NCBI TaxId: 1828522
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malayemys_khoratensis : Malayemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malayemys khoratensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malayemys_khoratensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1828522;
}
