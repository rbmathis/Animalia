namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina aculeata
/// NCBI TaxId: 661032
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_aculeata : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina aculeata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_aculeata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661032;
}
