namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Afrogecko;

/// <summary>
/// Species: Afrogecko porphyreus
/// NCBI TaxId: 221551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Afrogecko_porphyreus : Afrogecko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Afrogecko porphyreus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Afrogecko_porphyreus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221551;
}
