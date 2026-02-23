namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina oculata
/// NCBI TaxId: 661040
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_oculata : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina oculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_oculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661040;
}
