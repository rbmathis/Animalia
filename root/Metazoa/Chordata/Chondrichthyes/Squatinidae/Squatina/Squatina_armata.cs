namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina armata
/// NCBI TaxId: 661035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_armata : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina armata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_armata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661035;
}
