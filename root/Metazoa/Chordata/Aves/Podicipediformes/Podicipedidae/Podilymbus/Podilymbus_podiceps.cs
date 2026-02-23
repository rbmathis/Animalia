namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podilymbus;

/// <summary>
/// Species: Podilymbus podiceps
/// NCBI TaxId: 9252
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podilymbus_podiceps : Podilymbus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podilymbus podiceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podilymbus_podiceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9252;
}
