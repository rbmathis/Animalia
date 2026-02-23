namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

/// <summary>
/// Species: Triakis semifasciata
/// NCBI TaxId: 30493
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triakis_semifasciata : Triakis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triakis semifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triakis_semifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30493;
}
