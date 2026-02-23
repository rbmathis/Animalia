namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Species: Pseudemys concinna
/// NCBI TaxId: 270252
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemys_concinna : Pseudemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemys concinna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemys_concinna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270252;
}
