namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Species: Pseudemys rubriventris
/// NCBI TaxId: 580249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemys_rubriventris : Pseudemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemys rubriventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemys_rubriventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 580249;
}
