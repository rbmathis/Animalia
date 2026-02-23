namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podiceps;

/// <summary>
/// Species: Podiceps auritus
/// NCBI TaxId: 37050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podiceps_auritus : Podiceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podiceps auritus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podiceps_auritus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37050;
}
