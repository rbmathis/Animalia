namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina pseudocellata
/// NCBI TaxId: 661041
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_pseudocellata : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina pseudocellata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_pseudocellata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661041;
}
