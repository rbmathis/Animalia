namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina africana
/// NCBI TaxId: 661033
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_africana : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina africana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_africana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661033;
}
