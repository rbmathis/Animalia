namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina australis
/// NCBI TaxId: 335007
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_australis : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 335007;
}
