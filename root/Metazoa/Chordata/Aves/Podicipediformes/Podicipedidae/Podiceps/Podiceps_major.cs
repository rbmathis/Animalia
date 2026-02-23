namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podiceps;

/// <summary>
/// Species: Podiceps major
/// NCBI TaxId: 555330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podiceps_major : Podiceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podiceps major";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podiceps_major";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555330;
}
