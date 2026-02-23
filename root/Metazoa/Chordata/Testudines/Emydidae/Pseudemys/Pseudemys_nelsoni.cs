namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Species: Pseudemys nelsoni
/// NCBI TaxId: 301539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemys_nelsoni : Pseudemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemys nelsoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemys_nelsoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 301539;
}
