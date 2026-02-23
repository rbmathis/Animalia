namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina dumeril
/// NCBI TaxId: 303946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_dumeril : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina dumeril";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_dumeril";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303946;
}
