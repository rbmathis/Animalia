namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podiceps;

/// <summary>
/// Species: Podiceps cristatus
/// NCBI TaxId: 345573
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podiceps_cristatus : Podiceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podiceps cristatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podiceps_cristatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 345573;
}
