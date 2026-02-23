namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo cryptotympanicus
/// NCBI TaxId: 103431
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_cryptotympanicus : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo cryptotympanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_cryptotympanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103431;
}
